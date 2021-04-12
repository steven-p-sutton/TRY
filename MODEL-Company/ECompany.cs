using System;
using System.Collections.Generic;
using Conductus.EMPLOYEE.Model;
using Conductus.WIDGET.Model.Core;

namespace Conductus.COMPANY.Model
{
    public class ECompany : ICompany
    {
        //public string Name() { throw new NotImplementedException("Name"); }
        public string Name { 
            get
            {
                throw new CompanyNotImplentedException("get:Name");
            } 
            set 
            {
                throw new CompanyNotImplentedException("set:Name");
            }
        }
        public List<Employee> EmployeeList
        {
            get
            {
                throw new CompanyNotImplentedException("get:EmployeeList");
            }
            set
            {
                throw new CompanyNotImplentedException("set:EmployeeList");
            }
        }
        public List<Widget> WidgetList
        {
            get
            {
                throw new CompanyNotImplentedException("get:WidgetList");
            }
            set
            {
                throw new CompanyNotImplentedException("set:WidgetList");
            }
        }
        public List<Employee> Employees() { throw new CompanyNotImplentedException("Employees"); }
        public List<Widget> Widgets() { throw new CompanyNotImplentedException("Widgets"); }
    }
}
