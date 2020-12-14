using System;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1 steve = new Example1()
            {
               // Title = "Steve Example",
               // Output = Console.Out
            };
            steve.Go("Hello Steve Example World!");
        }
    }
}
