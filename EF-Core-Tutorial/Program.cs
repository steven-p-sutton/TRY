using System;
using DB_Context.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


// This is based oin the Tutotial here ->
//      https://www.yogihosting.com/conventions-entity-framework-core/
// Introduction
//      https://www.yogihosting.com/introduction-entity-framework-core/
// Installation
//      https://www.yogihosting.com/install-entity-framework-core/
//      - Microsoft.EntityFrameworkCore.SqlServer
//      - dotnet tool install --global dotnet-ef 
//        (dotnet tool update --global dotnet-ef)
//      - Microsoft.EntityFrameworkCore.Design
// Database First
//      https://www.yogihosting.com/database-first-approach-entity-framework-core/
// DBContext Class
//      https://www.yogihosting.com/dbcontext-entity-framework-core/
// Code First
//      https://www.yogihosting.com/code-first-entity-framework-core/
// Migrations
//      https://www.yogihosting.com/migrations-entity-framework-core/
// Insert Records
//      https://www.yogihosting.com/insert-records-entity-framework-core/
// Read Records
//      https://www.yogihosting.com/read-records-entity-framework-core/
//
namespace EF_Core_Tutorial
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello EF-Core-Tutorial World!");
            TryEF ef = new TryEF();

            
            Console.WriteLine("Insert Single Record");
            await ef.InsertSingleRecord();

            Console.WriteLine("Insert Multiple Records");
            await ef.InsertMultipleRecords();

            Console.WriteLine("Insert Related Records");
            await ef.InsertRelatedRecords();

            Console.WriteLine("Read Records");
            await ef.ReadRecords();

            Console.WriteLine("Read Related Eager Records");
            await ef.ReadRelatedEagerRecords();

            Console.WriteLine("Read Related Explicit Records");
            await ef.ReadRelatedEagerRecords();

            Console.WriteLine("Update Record");
            await ef.UpdateSingleRecord();

            Console.WriteLine("Update Multiple Records");
            await ef.UpdateMultipleRecords();            
            
            //Console.WriteLine("Update Related Records");
            //await ef.UpdateRelatedRecords();
            
            //Console.WriteLine("Delete Record");
            //await ef.DeleteRecord();
        }
    }
    public class TryEF
    {
        public async Task InsertSingleRecord()
        {
            // Insert/Create a Single Record

            var dept = new Department()
            {
                Name = "Designing"
            };
            using (var context = new CompanyContext())
            {
                context.Add(dept);
                await context.SaveChangesAsync();
            }
        }
        public async Task InsertMultipleRecords()
        {
            // Inserting/Creating Multiple Records

            var dept1 = new Department() { Name = "Development" };
            var dept2 = new Department() { Name = "HR" };
            var dept3 = new Department() { Name = "Marketing" };

            using (var context = new CompanyContext())
            {
                context.AddRange(dept1, dept2, dept3);
                await context.SaveChangesAsync();
            }
        }
        public async Task InsertRelatedRecords()
        {
            // Inserting Related Records

            var dept = new Department()
            {
                Name = "Admin"
            };

            var proj = new Project()
            {
                Name = "Project1"
            };

            var rep = new Report()
            {
                Name = "Report1",
                Project = proj
            };

            var emp = new Employee()
            {
                Name = "Matt",
                Designation = "Head",
                Department = dept,
                Project = proj
            };

            using (var context = new CompanyContext())
            {
                context.Add(emp);
                context.Add(rep);
                await context.SaveChangesAsync();
            }
        }
        public async Task ReadRecords()
        {
            // Reading Record

            using (var context = new CompanyContext())
            {
                // Eager Loading
                var emp = await context.Employee.Where
                (
                    e => e.Name == "Matt"
                )
                .FirstOrDefaultAsync();
            }
        }
        public async Task ReadRelatedEagerRecords()
        {
            // SELECT[e].[Id], [e].[Designation], [e].[Name], [e.Department].[Id], [e.Department].[Name]
            // FROM[Employee] AS[e]
            // LEFT JOIN[Department] AS[e.Department] ON[e].[DepartmentId] = [e.Department].[Id]
            // WHERE[e].[Name] = N'Matt'

            using (var context = new CompanyContext())
            {
                // Eager Loading Related record for Deparment read at time of reading Employee

                var empEager = await context.Employee.Where(e => e.Name == "Matt")
                    .Include(s => s.Department)
                    .FirstOrDefaultAsync();

                // Eager Loading Related record for Deparment & Project read at time of reading Employee

                var empEager2 = await context.Employee.Where(e => e.Name == "Matt")
                    .Include(s => s.Department)
                    .Include(s => s.Project)
                    .FirstOrDefaultAsync();

                // Eager Loading Related record for Deparment & Project read at time of reading Employee

                var empEager3 = await context.Employee.Where(e => e.Name == "Matt")
                    .Include(s => s.Department)
                    .Include(s => s.Project)
                    .ThenInclude(r => r.Report)
                    .FirstOrDefaultAsync();
            }
        }
        public async Task ReadRelatedExplicitRecords()
        {
            // Explicit Loading Related record for Deparmentm when its deemed right time to do so

            using (var context = new CompanyContext())
            {
                // Read main Employee receord
                var emp = await context.Employee.Where(e => e.Name == "Matt")
                    .FirstOrDefaultAsync();

                // Choose to load related Department data
                await context.Entry(emp).Reference(s => s.Department)
                    .LoadAsync();

                // With selecive query this time
                await context.Entry(emp).Reference(s => s.Department)
                    .Query()
                    .Where(s => s.Name == "Admin")
                    .LoadAsync();
            }
        }
        public async Task UpdateSingleRecord()
        {
            var dept = new Department()
            {
                Id = 37,
                Name = "Designing"
            };

            using (var context = new CompanyContext())
            {
                context.Update(dept);
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdateMultipleRecords()
        {
            var dept1 = new Department()
            {
                Id = 36,
                Name = "New Designing"
            };

            var dept2 = new Department()
            {
                Id = 37,
                Name = "New Research"
            };

            var dept3 = new Department()
            {
                Id = 38,
                Name = "New HR"
            };

            List<Department> modifiedDept = new List<Department>() { dept1, dept2, dept3 };

            using (var context = new CompanyContext())
            {
                context.UpdateRange(modifiedDept);
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdateRelatedRecords()
        {
            var dept = new Department()
            {
                Id = 5,
                Name = "Admin_1"
            };

            var emp = new Employee()
            {
                Id = 1,
                Name = "Matt_1",
                Designation = "Head_1",
                Department = dept
            };
            using (var context = new CompanyContext())
            {
                context.Update(emp);
                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteRecord()
        {
            var dept = new Department()
            {
                Id = 1002
            };

            using (var context = new CompanyContext())
            {
                context.Remove(dept);
                await context.SaveChangesAsync();
            }
        }
    }
}

