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
                    Run = IMock.RunType.SUCCESS,
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                Msg("MEmployee - ERROR");

                var employee2 = new MEmployee
                {
                    Run = IMock.RunType.EXCEPTION,
                    ExceptionExpected = new Exception("Employee Error"),
                    Throws = IMock.RunType.EXCEPTION,
                    Arrange = IMock.RunType.EXCEPTION,
                    Test = IMock.RunType.EXCEPTION,
                    Assert = IMock.RunType.EXCEPTION
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
