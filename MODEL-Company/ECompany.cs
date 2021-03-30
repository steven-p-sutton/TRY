using System;
using System.Collections.Generic;
using Conductus.MODEL.EMPLOYEE;
using Conductus.WIDGET.Model.Core;

namespace Conductus.MODEL.COMPANY
{
    public class ECompany : ICompany
    {
        //public string Name() { throw new NotImplementedException("Name"); }
        public string Name { 
            get
            {
                throw new NotImplementedException("get:Name");
            } 
            set 
            {
                throw new NotImplementedException("set:Name");
            }
        }
        public List<Employee> EmployeeList
        {
            get
            {
                throw new NotImplementedException("get:EmployeeList");
            }
            set
            {
                throw new NotImplementedException("set:EmployeeList");
            }
        }
        public List<Widget> WidgetList
        {
            get
            {
                throw new NotImplementedException("get:WidgetList");
            }
            set
            {
                throw new NotImplementedException("set:WidgetList");
            }
        }
        public List<Employee> Employees() { throw new NotImplementedException("Employees"); }
        public List<Widget> Widgets() { throw new NotImplementedException("Widgets"); }
    }
}
