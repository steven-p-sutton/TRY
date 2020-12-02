using System;

namespace SQLCoreApp
{
    public class ConnectionMSSQLStringBuilder : ConnectionStringBuilder
    {
        public ConnectionMSSQLStringBuilder()
        {
            this.Server = "LocalDB";
            this.Database = "MSSQLLocalDb";
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionMSSQLStringBuilder(string Server)
        {
            this.Server = Server;
            this.Database = "MSSQLLocalDb";
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionMSSQLStringBuilder (string Server, string Database)
        {
            this.Server = Server;
            this.Database = Database;
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionMSSQLStringBuilder(string Server, string Database, string UserName, string Password)
        {
            this.Server = Server;
            this.Database = Database;
            this.IntegratedSecurity = false;
            this.UserName = UserName;
            this.Password = Password;
        }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IntegratedSecurity { get; set; }
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
