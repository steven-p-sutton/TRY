using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Conductus.MODEL.EMPLOYEE;

namespace Conductus.MODEL.COMPANY
{
    public class Company : ICompany
    {
        private string _name;
        private List<Employee> _employees;
        private List<Widget> _widgets;

        public Company(string name, List<Employee> employees, List<Widget> widgets)
        {
            _name = name;
            _employees = employees;
            _widgets = widgets;
        }
        public string Name() { return _name; }
        public List<Employee> Employees() { return _employees; }
        public List<Widget> Widgets() { return _widgets; }
    }
}
