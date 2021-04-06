using System;
using Conductus.CODERUN.Model.Core;

namespace Conductus.CODERUN.Try
{
    public class CodeRunTry : ICodeRunModule
    {
        public string Title
        {
            get { return "CodeRun Try"; }
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Module:Run() called");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
