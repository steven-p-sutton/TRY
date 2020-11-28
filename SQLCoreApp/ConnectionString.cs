using System;
using System.Collections.Generic;
using System.Text;

namespace SQLCoreApp
{
    public class ConnectionStringBuilder
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public bool IntegratedSecurity { set; get; }
        public string Mine
        {
            get {
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
}
