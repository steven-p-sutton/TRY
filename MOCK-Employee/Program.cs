using System;
using MOCK.Framework;
using nsEmployee;

namespace MOCK_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var widget = new MEmployee
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                var widget2 = new MEmployee
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
