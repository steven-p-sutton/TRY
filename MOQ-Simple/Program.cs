﻿using System;
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

            employee.Verifyable = true;
            employee.Returns = true;
            employee.Throws(new Exception(), "Hello world");

            Console.WriteLine(employee.Mock.Object.GetDateOfJoining(1));

            employee.Verify = 0;

            Console.ReadLine();
        }
    }
}

