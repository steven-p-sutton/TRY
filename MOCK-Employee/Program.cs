using System;
using Conductus.EMPLOYEE.Model;

namespace Conductus.EMPLOYEE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var employee = new MEmployee
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };

                var employee2 = new MEmployee
                {
                    Run = IMock.RunType.EXCEPTION,
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
            Console.ReadLine();
        }
    }
}
