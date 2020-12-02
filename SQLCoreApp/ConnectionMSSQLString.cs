using System;

namespace SQLCoreApp
{
    public class ConnectionMSSQLStringBuilder : ConnectionStringBuilder
    {
        private string Server { get; set; }
        private string Database { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private bool IntegratedSecurity { get; set; }
        public ConnectionMSSQLStringBuilder(string Database)
        {
            // appsettings.json 
            // 
            // "ConnectionStrings": {
            //    "Database": "Widget",
            // }

            // No server, so SQLExpress/LocalDB
            this.Server = "(LocalDB)\\MSSQLLocalDB";
            // Database always required
            this.Database = Database;
            // No Username/Password, so Windows Authentication
            this.UserName = String.Empty;
            this.Password = String.Empty;
            this.IntegratedSecurity = true;
        }
        public ConnectionMSSQLStringBuilder(string Server, string Database)
        {
            // appsettings.json 
            // 
            // "ConnectionStrings": {
            //    "Server": "LAPTOP-QR0QPGVQ",
            //    "Database": "Widget",
            // } 

            // Server, so MS-SQL (LocalDB could be passed in if desired)
            this.Server = Server;
            // Database always required
            this.Database = Database;
            // No Username/Password, so Windows Authentication
            this.UserName = String.Empty;
            this.Password = String.Empty;
            this.IntegratedSecurity = true;
        }
        public ConnectionMSSQLStringBuilder(string Database, string UserName, string Password)
        {
            // appsettings.json 
            // 
            // "ConnectionStrings": {
            //    "Database": "Widget",
            //    "UserName": "WidgetUser",
            //    "Password": "234c232v2",
            // } 

            // No server, so SQLExpress/LocalDB
            this.Server = "(LocalDB)\\MSSQLLocalDB";
            // Database always required
            this.Database = Database;
            // Username/Password, so SQL Server authentication
            this.IntegratedSecurity = false;
            this.UserName = UserName;
            this.Password = Password;
        }
        public ConnectionMSSQLStringBuilder(string Server, string Database, string UserName, string Password)
        {
            // appsettings.json 
            // 
            // "ConnectionStrings": {
            //    "Server": "LAPTOP-QR0QPGVQ",
            //    "Database": "Widget",
            //    "UserName": "WidgetUser",
            //    "Password": "234c232v2",
            // } 

            // Server, so MS-SQL (LocalDB could be passed in if desired)
            this.Server = Server;
            // Database always required
            this.Database = Database;
            // Username/Password, so SQL Server authentication
            this.UserName = UserName;
            this.Password = Password;
            this.IntegratedSecurity = false;
        }
        public override string ToString()
        {
            string s = string.Empty;

            s = String.Format("Server={0}; Database={1};", this.Server, this.Database);

            if (this.IntegratedSecurity)
            {
                // Windows Authentication
                s = s + " Integrated Security=SSPI;";
            }
            else
            {
                // SQL Server Authentication
                s = s + String.Format(" User Id= {0}; Password={1};", this.UserName, this.Password);
            }
            return s;
        }
    }
}
