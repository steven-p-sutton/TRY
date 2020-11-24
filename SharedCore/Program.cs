using System;
// using WidgetObject from SharedCode project

namespace SharedCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Net Widget World!");
            WidgetObject w2 = new WidgetObject();
            Console.WriteLine(w2.Display("Widget 2"));
        }
    }
}
