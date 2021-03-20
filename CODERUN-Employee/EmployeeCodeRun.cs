using System;
using CODERUN.Framework;
using nsEmployee;

namespace CODERUN.EmployeeNS
{
    public class EmployeeCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Sample Code Run"; }
        }

        public void Run()
        {
            var employee = new Employee();
            Console.WriteLine(employee.GetDateOfJoining(1));
        }
    }
}
