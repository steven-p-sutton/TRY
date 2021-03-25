﻿using Conductus.CODERUN.Framework; // ICodeRun & 
using Conductus.CODERUN.SAMPLE;
using Conductus.CODERUN.GENERICARRAY;
using Conductus.CODERUN.GENERICDELEGATE;
using Conductus.CODERUN.GENERICMETHOD;
using Conductus.CODERUN.EMPLOYEE;
using Conductus.CODERUN.WIDGET;

namespace CODERUN.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Each code module to run implenets the ICodeRunModule interface.
            // Built as a .NET Core class library dll and refernced by itsnamespace
            // Call CodeRunModule using CodeRunFramework.run(CodeRunModule)

            var cr = new SampleCodeRun();
            CodeRunFramework.Run(cr);

            var ga = new GenericArrayCodeRun();
            CodeRunFramework.Run(ga);

            var gd = new GenericDelegateRun();
            CodeRunFramework.Run(gd);

            var gm = new GenericMethodRun();
            CodeRunFramework.Run(gm);

            var sa = new SampleCodeRun();
            CodeRunFramework.Run(sa);

            var em = new EmployeeCodeRun();
            CodeRunFramework.Run(em);

            var wd = new WidgetCodeRun();
            CodeRunFramework.Run(wd);
        }
    }
}
