using System;

//Generics<T>
//    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
//	  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes
//    https://www.tutorialspoint.com/csharp/csharp_generics.htm
//    https://www.tutorialsteacher.com/csharp/csharp-generics

namespace GENERICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GENERICS World!");

            Console.WriteLine("\n<int> is the type argument");

            GenericList<int> list1 = new GenericList<int>();

            for (int x = 0; x < 10; x++)
            {
                list1.AddHead(x);
            }

            foreach (int i in list1)
            {
                Console.Write(i + " \n");
            }

            Console.WriteLine("\n<string> is the type argument");
            // 

            GenericList<string> list2 = new GenericList<string>();

            list2.AddHead("Steve");
            list2.AddHead("Philip");
            list2.AddHead("Sutton");

            foreach (string s in list2)
            {
                Console.Write(s + " \n");
            }

            Console.WriteLine("\nDone");
            Console.ReadLine();
        }
    }
}
