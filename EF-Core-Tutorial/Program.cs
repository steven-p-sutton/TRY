using System;
using DB_Context.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


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
//
// 
namespace EF_Core_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EF-Core_Tutorial World!");

            using (var context = new CompanyContext())
            {
                var dept = new Department()
                {
                    Name = "Designing"
                };
                context.Entry(dept).State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
