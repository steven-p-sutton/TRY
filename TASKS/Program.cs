using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/

namespace TASKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cup = new Coffee().PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = new Egg().FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = new Bacon().FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = new Toast().ToastBread(2);
            toast.ApplyButter(toast);
            toast.ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = new Juice().PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }
    }
}
