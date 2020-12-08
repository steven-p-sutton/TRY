using System;
using DB_Context.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;


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
                //context.SaveChanges();
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
                //context.SaveChanges();
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

            var emp = new Employee()
            {
                Name = "Matt",
                Designation = "Head",
                Department = dept
            };

            using (var context = new CompanyContext())
            {
                context.Add(emp);
                //context.SaveChanges();
                await context.SaveChangesAsync();
            }
        }
        public async Task ReadRecords()
        {
            // Reading Records

            using (var context = new CompanyContext())
            {
                var emp = await context.Employee.Where(e => e.Name == "Matt").FirstOrDefaultAsync();
                //var emp = context.Employee.Where(e => e.Name == "Matt").FirstOrDefaultAsync();
            }
        }
    }
}

