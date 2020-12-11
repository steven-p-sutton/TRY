// Based on turorial 
//   https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
// 

using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }
        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
        static void Main(string[] args)
        {
            TryLINQ linq = new TryLINQ(Suits(), Ranks());

            Console.WriteLine("1. Create the Data Set ...");

            Console.WriteLine("1.1. Using query syntax ...");
            linq.QuerySyntax();

            Console.WriteLine("1.2. Using method  syntax ...");
            linq.MethodSyntax();

            Console.WriteLine("2. Manipulate the Order ...");

        }
    }
}
