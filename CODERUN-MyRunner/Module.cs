using System;
//using Conductus.CODERUN.Library.Core;

namespace Conductus.CODERUN.Try
{
    public class Module : ICodeRunModule
    {
        public string Title
        {
            get { return "Try Code Run"; }
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
