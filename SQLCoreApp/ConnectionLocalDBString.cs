using System;

namespace SQLCoreApp
{
    public class ConnectionLocalDBStringBuilder: ConnectionStringBuilder
    {
        public ConnectionLocalDBStringBuilder()
        {
        }
        public ConnectionLocalDBStringBuilder(string Database, string IntegratedSecurity)
        {
            this.Server = Server;
            this.Database = Database;

            Boolean b = false;
            if (bool.TryParse(IntegratedSecurity, out b))
            {
                this.IntegratedSecurity = b;
            }
        }
        public string Server = "LocalDB\\(MSSQLLocalDb)";
        public string Database { get; set; }
        public bool IntegratedSecurity { get; set; }
        public override string ToString()
        {
            string s = string.Empty;

            s = String.Format("Server={0}; Database={1}; ",
                    this.Server,
                    this.Database);

            if (this.IntegratedSecurity)
            {
                s = s + "Integrated Security=SSPI;";
            }
            return s;
        }
    }
}
