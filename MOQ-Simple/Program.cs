using System;
using Mock;
using nsEmployee;

// https://www.codeproject.com/articles/991028/using-moq-for-unit-testing
//
// Overview: Try an Employee, as yes not fully implemented, using a mocked, test only version
// 

namespace MOQ_Employee
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
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                var employee2 = new MEmployee
                {
                    Run = IMock.RunType.EXCEPTION,
                    Exception = new Exception("Employee Error"),
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
            Console.ReadLine();
        }
    }
}

