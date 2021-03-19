using System;
using nsWidget;

namespace MOQ_Widget
{
    class Program
    {
        static void Main(string[] args)
        {
            var widget = new MWidget();

            widget.Verifyable = false;
            widget.Returns = true;
            //widget.Throws(new Exception(), "Hello world");

            Console.WriteLine(widget.Mock.Object.Ping(2,3));
            Console.WriteLine(widget.Mock.Object.Display("Unit Test"));

            widget.Verify = 1;

            Console.ReadLine();
        }
    }
}
