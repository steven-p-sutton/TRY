﻿using System;
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
            var employee = new MEmployee
            {
                Run = IMock.RunType.SUCCESS,Added 
            };

            var employee2 = new MEmployee
            {
                Run = IMock.RunType.EXCEPTION,
                Exception = new Exception("Employee Error"),
                Arrange = IMock.RunType.EXCEPTION,
                Test = IMock.RunType.EXCEPTION,
                Assert = IMock.RunType.EXCEPTION,
            };

            Console.ReadLine();
        }
    }
}

