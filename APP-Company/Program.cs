using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Conductus.EMPLOYEE.Model;
using Conductus.WIDGET.Model.Core;
using Conductus.COMPANY.Model;

namespace Conductus.COMPANY.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            var widgets = new List<Widget>();
            var widget1 = new Widget()
            {
                Id = 1,
                Date = DateTime.Today,
                Name = "Widget1",
                Count = 99
            };
            var widget2 = new Widget()
            {
                Id = 2,
                Date = DateTime.Today,
                Name = "Widget2",
                Count = 98
            };

            widgets.Add(widget1);
            widgets.Add(widget2);

            var employees = new List<Employee>();
            var employee = new Employee("Steve", DateTime.Parse("17-03-1963"));
            employees.Add(employee);

            var employee2 = new Employee("Bob", DateTime.Parse("31-03-1963"));
            employees.Add(employee2);

            var company = new Company("Conductus", employees, widgets);

            string json = JsonConvert.SerializeObject(company.Employees(), Formatting.Indented);
            Console.WriteLine (json);

            Console.WriteLine(company.Name);

            foreach (var e in company.EmployeeList)
            {
                Console.WriteLine(e.Name());
            }

            foreach (var w in company.WidgetList)
            {
                Console.WriteLine(w.Name);
            }
        }
    }
}
