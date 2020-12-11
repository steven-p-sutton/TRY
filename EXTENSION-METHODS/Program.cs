using System;
using ExtensionMethods;

namespace EXTENSION_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);
        }
    }
}
