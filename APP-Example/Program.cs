﻿using System;
using Conductus.EXAMPLE.Model;

namespace Conductus.EXAMPLE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example

            try
            {
                var example = new Example();

                example.Str = "APP-Example";
                example.Int = 99;
                example.Add(example.Str);
                example.Add(example.Int.ToString());

                foreach (var item in example.Repository)
                    Console.WriteLine(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // HExample

            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // EExample

            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // MEXample

            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
