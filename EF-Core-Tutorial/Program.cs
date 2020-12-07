using System;
using DB_Context.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EF-Core-Tutorial World!");

            var dept = new Department();

            // Insert/Create a Single Record

            dept = new Department()
            {
                Name = "Designing"
            };
            using (var context = new CompanyContext())
            {
                context.Add(dept);
                context.SaveChanges();
                //await context.SaveChangesAsync();
            }

            // Inserting/Creating Multiple Records

            var dept1 = new Department() { Name = "Development" };
            var dept2 = new Department() { Name = "HR" };
            var dept3 = new Department() { Name = "Marketing" };

            using (var context = new CompanyContext())
            {
                context.AddRange(dept1, dept2, dept3);
                context.SaveChanges();
                //await context.SaveChangesAsync();
            }

            // Inserting Related Records

            dept = new Department()
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
                context.SaveChanges();
                //await context.SaveChangesAsync();
            }

            // 

        }
    }
}

