using System;
using Conductus.CODERUN.Library.Core;

namespace Conductus.TRY.CodeRunIt
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
