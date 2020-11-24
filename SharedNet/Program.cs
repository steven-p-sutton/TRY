using System;
// using WidgetObject from SharedCode project

namespace SharedNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Core Widget World!");
            WidgetObject w1 = new WidgetObject();
            Console.WriteLine(w1.Display("Hello Widget1"));
        }
    }
}
