using System;
using System.Linq;

// Microsoft Entity Framework
//		https://docs.microsoft.com/en-us/ef/

//		Entity Framework 6
//			https://docs.microsoft.com/en-us/ef/ef6/
//			Get started with Entity Framework 6
//
//          Tutorial
//              https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
//
//              Database is created in SQLExpress when app is run first time
//
//              VS2019/Server Explorer
//                                SERVER = laptop-qr0qpgvq\localdb#ec7f3d87.master.dbo (enterd as (LocalDB)\MSSQLLocalDB
//                      CONNECTIONSTRING = Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=True
//                  SSMS
//                                SERVER = LAPTOP - QR0QPGVQ\LOCALDB#631D7789
//                                    DB = CodeFirstNewDatabaseSample.BloggingContext

//              MSSQL
//                                DB = LAPTOP-QR0QPGVQ
//                  CONNECTIONSTRING = Data Source=LAPTOP-QR0QPGVQ;Integrated Security=True
//                  

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
