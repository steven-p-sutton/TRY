using System;

namespace SQLCoreApp
{
    public class ConnectionMSSQLExpressStringBuilder: ConnectionStringBuilder
    {
        public ConnectionMSSQLExpressStringBuilder()
        {
        }
        public ConnectionMSSQLExpressStringBuilder(string Server, string Database, string IntegratedSecurity)
        {
            this.Server = Server;
            this.Database = Database;

            Boolean b = false;
            if (bool.TryParse(IntegratedSecurity, out b))
            {
                this.IntegratedSecurity = b;
            }
        }
        public string Server { get; set; }
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
