using System;

// https://csharp.hotexamples.com/examples/-/SqlConnection/-/php-sqlconnection-class-examples.html
// Types:
//
// Standard Security
//      Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;
// Trusted Connection
//      Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
// 
namespace SQLCoreApp
{
    public class ConnectionStringBuilder
    {
        public ConnectionStringBuilder()
        {
        }
        public override string ToString()
       {
            return String.Empty;
       }
    }
}
