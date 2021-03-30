using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Conductus.MODEL.EMPLOYEE;
using Conductus.MODEL.COMPANY;

namespace Conductus.APP.COMPANY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var widget = new Widget()
            {
                Id = 1,
                Date = DateTime.Today,
                Name = "Widget",
                Count = 99
            };

            var widgets = new List<Widget>();
            widgets.Add(widget);

            var employee = new Employee("Steve", DateTime.Parse("17-03-1963"));
            var employees = new List<Employee>();
            employees.Add(employee);

            var company = new Company("Conductus", employees, widgets);

            string json = JsonConvert.SerializeObject(company.Employees(), Formatting.Indented);
            Console.WriteLine (json);
        }
    }
}
