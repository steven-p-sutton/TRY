using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class TryLINQ
    {
        private IEnumerable<string> l_suits;
        private IEnumerable<string> l_ranks;

        public TryLINQ(IEnumerable<string> Suits, IEnumerable<string> Ranks)
        {
            l_suits = Suits;
            l_ranks = Ranks;
        }
        public void QuerySyntax()
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

            var startingDeck = from s in l_suits
                               from r in l_ranks
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }

        public void MethodSyntax()
        {
            var startingDeck = l_ranks.SelectMany(suit => l_suits.Select(rank => new { Suit = suit, Rank = rank }));

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

        }
    }
}
