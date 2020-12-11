// Based on turorial 
//   https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
// 

using System;
using System.Collections.Generic;
using System.Linq;

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
            /*
             * The multiple from clauses produce a SelectMany, which creates a single sequence from 
             * combining each element in the first sequence with each element in the second sequence. 
             * The order is important for our purposes. The first element in the first source sequence 
             * (Suits) is combined with every element in the second sequence (Ranks). This produces 
             * all thirteen cards of first suit. That process is repeated with each element in the 
             * first sequence (Suits). The end result is a deck of cards ordered by suits, followed 
             * by values.
             */
            var startingDeck1 = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck1)
            {
                Console.WriteLine(card);
            }

            var startingDeck2 = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));

        }
    }
}
