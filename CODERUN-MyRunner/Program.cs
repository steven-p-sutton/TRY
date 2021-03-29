using System;
using Conductus.CODERUN.Library.Core;
using Conductus.CODERUN.EMPLOYEE;
using Conductus.CODERUN.WIDGET;

namespace CODERUN_MyRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new EmployeeCodeRun();
            CodeRunFramework.Run(em);

            var wd = new WidgetCodeRun();
            CodeRunFramework.Run(wd);
        }
    }
}
