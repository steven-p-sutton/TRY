using System;
using System.Collections.Generic;
using nsEmployee;

namespace nsCompany
{
    public interface ICompany
    {
        public string Name ();
        public List<Employee> Employees();
        public List<WidgetObject> Widgets();
    }
}
