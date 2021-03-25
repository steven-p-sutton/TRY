using System;
using System.Collections.Generic;
using Conductus.MODEL.EMPLOYEE;

namespace nsCompany
{
    public interface ICompany
    {
        public string Name ();
        public List<Employee> Employees();
        public List<Widget> Widgets();
    }
}
