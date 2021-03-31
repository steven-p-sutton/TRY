using System;
using Conductus.CODERUN.Library.Core;

namespace Conductus.CODERUN.TRY
{
    public class Module
    {
        public Module()
        {
            Console.WriteLine("Module:constructer");
        }
    }
    public class ModuleCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Try Code Run"; }
        }

        public void Run()
        {
            try
            {
                var m = new Module();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
