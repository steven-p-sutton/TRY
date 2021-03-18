﻿using CODERUN.Framework; // ICodeRun & 
using CODERUN.Sample;
using CODERUN.GenericArray;
using CODERUN.GenericDelegate;
using CODERUN.GenericMethod;


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

            //var gd = new CODERUN.GenericDelegate.GenericDelegateCodeRun();
            //CodeRunFramework.Run(gd);

            //var gm = new CODERUN.GenericMethod.GenericMethodCodeRun();
            //CodeRunFramework.Run(gm);
        }
    }
}