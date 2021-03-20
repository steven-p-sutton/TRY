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
            var employee = new MEmployee
            {
                Arrange = true,
                Run = true,
                Assert = true
            };
            //employee.Arrange = true;
            //employee.Run = true;
            //employee.Assert = true;

            var employee2 = new MEmployee
            {
                Arrange = false,
                Run = false,
                Assert = false
            };

            Console.ReadLine();
        }
    }
}

