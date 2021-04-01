using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Conductus.EMPLOYEE.Model;

namespace Conductus.COMPANY.Model
{
    public class Company : ICompany
    {
        //private string _name;
        private List<Employee> _employees;
        private List<Widget> _widgets;

        public Company(string name, List<Employee> employees, List<Widget> widgets)
        {
            //_name = name;
            this.Name = name;
            _employees = employees;
            _widgets = widgets;
        }

        //public string Name() { return _name; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("employeeList")]
        public List<Employee> EmployeeList 
        {
            get{ return _employees; }
            set{ _employees = value; } 
        }

        [JsonProperty("widgetList")]
        public List<Widget> WidgetList 
        {
            get { return _widgets; }
            set { _widgets = value; }
        }

        public List<Employee> Employees() { return _employees; }

        public List<Widget> Widgets() { return _widgets; }
    }
}
