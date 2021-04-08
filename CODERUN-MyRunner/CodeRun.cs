using System;
using Conductus.CODERUN.Model.Core;

namespace Conductus.TRY.CODERUN
{
    public class CodeRunTry : ICodeRunModule
    {
        public override string Title
        {
            get { return "CodeRun Try"; }
        }

        public override void Run()
        {
            try
            {
                Msg("Just call Run()");

                Console.WriteLine("Module:Run() called");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
