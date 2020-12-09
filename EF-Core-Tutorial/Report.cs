using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Context.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
