using System;
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
            var employee = new MEmployee();
            employee.Arrange();
            employee.Run();
            employee.Assert();

            Console.ReadLine();
        }
    }
}

