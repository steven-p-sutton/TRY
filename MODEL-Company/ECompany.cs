using System;
using System.Collections.Generic;
using Conductus.MODEL.EMPLOYEE;
using Conductus.WIDGET.Model.Core;

namespace Conductus.MODEL.COMPANY
{
    public class ECompany : ICompany
    {
        public string Name() { throw new NotImplementedException("Name"); }
        public List<Employee> Employees() { throw new NotImplementedException("Employees"); }
        public List<Widget> Widgets() { throw new NotImplementedException("Widgets"); }
    }
}
