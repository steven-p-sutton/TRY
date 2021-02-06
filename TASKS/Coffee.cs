using System;
using System.Collections.Generic;
using System.Text;

namespace TASKS
{
    public class Coffee
    {
        public Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
