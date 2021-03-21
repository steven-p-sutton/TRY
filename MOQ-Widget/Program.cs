﻿using System;
using MOQ.Framework;
using nsWidget;

namespace MOQ_Widget
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var widget = new MWidget
                {
                    Run = IMock.RunType.SUCCESS,
                    Arrange = IMock.RunType.SUCCESS,
                    Test = IMock.RunType.SUCCESS,
                    Assert = IMock.RunType.SUCCESS
                };

                var widget2 = new MWidget
                {
                    Run = IMock.RunType.EXCEPTION,
                    Exception = new Exception("Widget Error"),
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
