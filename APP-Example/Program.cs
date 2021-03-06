﻿using System;
using Conductus.EXAMPLE.Model;
using Conductus.EXCEPTION.Model.Core;

namespace Conductus.EXAMPLE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example

            //try
            //{
            //    var example = new Example();

            //    example.Str = "APP-Example";
            //    example.Int = 99;
            //    example.Add(example.Str);
            //    example.Add(example.Int.ToString());

            //    foreach (var item in example.Repository)
            //        Console.WriteLine(item);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // HExample

            //try
            //{
            //    var host = new HExample();

            //    var s = host.Str();
            //    var i = host.Int();

            //    host.Add();
            //    host.Find();
            //    host.Remove();

            //    host.Try = true;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // EExample

            //try
            //{
            //    var empty = new EExample();

            //    empty.Add("Item");
            //    empty.Remove(empty.Find("Item"));
            //}
            //catch (ExampleNotImplentedException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // MEXample

            try
            {
                //var mockOK = new MExample
                //{
                //    Run = IMock.RunType.SUCCESS,
                //    Arrange = IMock.RunType.SUCCESS,
                //    Test = IMock.RunType.SUCCESS,
                //    Assert = IMock.RunType.SUCCESS
                //};

                var  mockERROR= new MExample
                {
                    Run = IMock.RunType.EXCEPTION,
                    ExceptionExpected = new ExampleAlreadyExistsException("Mock ERROR"),
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
