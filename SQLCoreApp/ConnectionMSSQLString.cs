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
            this.Server = "(LocalDB)\\MSSQLLocalDB";
            this.Database = Database;
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionMSSQLStringBuilder(string Server, string Database)
        {
            this.Server = Server;
            this.Database = Database;
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionMSSQLStringBuilder(string Database, string UserName, string Password)
        {
            this.Server = "(LocalDB)\\MSSQLLocalDB";
            this.Database = Database;
            this.IntegratedSecurity = false;
            this.UserName = UserName;
            this.Password = Password;
        }
        public ConnectionMSSQLStringBuilder(string Server, string Database, string UserName, string Password)
        {
            this.Server = Server;
            this.Database = Database;
            this.IntegratedSecurity = false;
            this.UserName = UserName;
            this.Password = Password;
        }
        public override string ToString()
        {
            string s = string.Empty;

            s = String.Format("Server={0}; Database={1};", this.Server, this.Database);

            if (this.IntegratedSecurity)
            {
                s = s + " Integrated Security=SSPI;";
            }
            else
            {
                s = s + String.Format(" User Id= {0}; Password={1};", this.UserName, this.Password);
            }
            return s;
        }
    }
}
