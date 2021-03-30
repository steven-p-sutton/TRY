using System;
using System.Collections.Generic;
using Conductus.MODEL.EMPLOYEE;
using Conductus.WIDGET.Model.Core;

namespace Conductus.MODEL.COMPANY
{
    public interface ICompany
    {
        public string Name ();
        public List<Employee> Employees();
        public List<Widget> Widgets();
    }
}
