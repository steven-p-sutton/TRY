using System;

namespace SQLCoreApp
{
    public class ConnectionLocalDBStringBuilder: ConnectionStringBuilder
    {
        public ConnectionLocalDBStringBuilder(string Database)
        {
            this.Database = Database;
            this.IntegratedSecurity = true;
            this.UserName = String.Empty;
            this.Password = String.Empty;
        }
        public ConnectionLocalDBStringBuilder(string Database, string UserName, string Password)
        {
            this.Database = Database;
            this.IntegratedSecurity = false;
            this.UserName = UserName;
            this.Password = Password;
        }
        public ConnectionLocalDBStringBuilder(string Database, string IntegratedSecurity, string UserName, string Password)
        {
            this.Database = Database;
            Boolean b = false;
            bool.TryParse(IntegratedSecurity, out b);
            this.UserName = UserName;
            this.Password = Password;
        }
        public string Server = "LocalDB\\(MSSQLLocalDb)";
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IntegratedSecurity { get; set; }
        public override string ToString() // also: => FirstName + "  " + ID;
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
