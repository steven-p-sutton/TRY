using System;
using Conductus.CODERUN.Model.Core;
using Conductus.EMPLOYEE.Model;

namespace Conductus.EMPLOYEE.CODERUN
{
    public class CodeRun : ACodeRunModule
    {
        public override string Title
        {
            get { return "RunCode Employee"; }
        }

        public override void Run()
        { 
            try
            {
                Msg("MEmployee - OK");

                var employee = new MEmployee
                {
                    Run = IRunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                Msg("MEmployee - ERROR");

                var employee2 = new MEmployee
                {
                    Run = IRunType.EXCEPTION,
                    ExceptionExpected = new Exception("Employee Error"),
                    Throws = true,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
