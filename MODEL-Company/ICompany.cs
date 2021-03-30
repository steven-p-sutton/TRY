using System;
using System.Collections.Generic;
using Conductus.MODEL.EMPLOYEE;
using Conductus.WIDGET.Model.Core;

namespace Conductus.MODEL.COMPANY
{
    public interface ICompany
    {
        //public string Name ();
        public string Name { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<Widget> WidgetList { get; set; }
        public List<Employee> Employees();
        public List<Widget> Widgets();
    }
}
