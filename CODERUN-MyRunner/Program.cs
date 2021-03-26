using System;
using Conductus.CODERUN.Library.Core;
using Conductus.CODERUN.GENERICARRAY;
using Conductus.CODERUN.GENERICDELEGATE;
using Conductus.CODERUN.GENERICMETHOD;
using Conductus.CODERUN.EMPLOYEE;
using Conductus.CODERUN.WIDGET;

namespace CODERUN_MyRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var ga = new GenericArrayCodeRun();
            CodeRunFramework.Run(ga);

            var gd = new GenericDelegateRun();
            CodeRunFramework.Run(gd);

            var gm = new GenericMethodRun();
            CodeRunFramework.Run(gm);

            var em = new EmployeeCodeRun();
            CodeRunFramework.Run(em);

            var wd = new WidgetCodeRun();
            CodeRunFramework.Run(wd);
        }
    }
}
