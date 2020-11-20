using System;
using System.Data.SqlClient;
//
// Try connection to a database
//
// https://www.c-sharpcorner.com/blogs/access-sql-server-database-in-net-core-console-application
// 
// NUGet 
//      Microsoft.Extensions.Configuration
//      Microsoft.Extensions.Configuration.FileExtensions
//      Microsoft.Extensions.Configuration.Json
//      System.Data.SqlClient
//
// appsetings.json
//      {
//          "ConnectionStrings": {
//              "Default": "Server=YOUR_SERVER;Database=mydatabase;User  Id=YOUR_USER;Password=YOUR_PASSWORD;MultipleActiveResultSets=true"
//          }
//      }
//
// ConnectionStrings
//      https://www.connectionstrings.com/sql-server/
//      https://csharp.hotexamples.com/examples/-/SqlConnection/-/php-sqlconnection-class-examples.html
//      https://stackoverflow.com/questions/15631602/how-to-set-sql-server-connection-string

//.NET DataProvider -- Standard Connection with username and password
//
//using System.Data.SqlClient;
/*
SqlConnection conn = new SqlConnection();
conn.ConnectionString =
  "Data Source=ServerName;" +
  "Initial Catalog=DataBaseName;" +
 "User id=UserName;" +
  "Password=Secret;";
conn.Open();
*/

//.NET DataProvider -- Trusted Connection
//
/*
SqlConnection conn = new SqlConnection();
conn.ConnectionString =
  "Data Source=ServerName;" +
  "Initial Catalog=DataBaseName;" +
  "Integrated Security=SSPI;";
conn.Open();
*/

// https://docs.microsoft.com/en-us/previous-versions/aspnet/jj653752(v=vs.110)?redirectedfrom=MSDN#sqlserver


namespace SQLCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=LAPTOP-QR0QPGVQ;" +
              "Initial Catalog=Widget;" +
              "Integrated Security=SSPI;";
            conn.Open();
        }
    }
}
