using System;
using nsEmployee;

// https://www.codeproject.com/articles/991028/using-moq-for-unit-testing
//
// Overview: Try an Employee, as yes not fully implemented, using a mocked, test only version
// 

namespace MOQ_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new MEmployee();

            employee.Verifyable = true;
            employee.Returns = true;

            Console.WriteLine(employee.Mock.Object.GetDateOfJoining(1));

            employee.Verify = 1;

            Console.ReadLine();
        }
    }
}

