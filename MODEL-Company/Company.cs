using System;
using System.Collections.Generic;
using nsEmployee;

namespace nsCompany
{
    public class Company : ICompany
    {
        public string Name() { throw new NotImplementedException(); }
        public List<Employee> Employees() { throw new NotImplementedException(); }
        public List<WidgetObject> Widgets() { throw new NotImplementedException(); }
    }
}
