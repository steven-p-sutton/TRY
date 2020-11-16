using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CodeFirstNewDatabaseAnnotations
{
    public class User
    {
        [Key] 
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
}
