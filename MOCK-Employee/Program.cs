﻿using System;
using Conductus.MODEL.EMPLOYEE;

namespace Conductus.APP.EMPLOYEE
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
            Console.ReadLine();
        }
    }
}
