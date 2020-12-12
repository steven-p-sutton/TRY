using System;
using System.Collections.Generic;
using System.Linq;
using LinqFaroShuffle; //Extensions.sc

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
        public void QuerySyntax(string message)
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

            if (message != null)
            {
                Console.WriteLine(message);
            }

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }
        public void MethodSyntax(string message)
        {
            var startingDeck = l_ranks.SelectMany(suit => l_suits.Select(rank => new { Suit = suit, Rank = rank }));

            // Display each card that we've generated and placed in startingDeck in the console

            if (message != null)
            {
                Console.WriteLine(message);
            }

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }
        public void ManipulateOrder(string message)
        {
            /*
             * shuffle the cards in the deck.The first step in any good shuffle is to split the 
             * deck in two.The Take and Skip methods that are part of the LINQ APIs provide that
             * feature for you.
             */

            var startingDeck = from s in l_suits
                               from r in l_ranks
                               select new { Suit = s, Rank = r };

            // 52 cards in a deck, so 52 / 2 = 26
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);

            var shuffle = top.InterleaveSequenceWith(bottom);

            if (message != null)
            {
                Console.WriteLine(message);
            }

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
        }
        public void PipelineProcessing(string message)
        {
            var startingDeck = from s in l_suits
                               from r in l_ranks
                               select new { Suit = s, Rank = r };

            if (message != null)
            {
                Console.WriteLine("BEFORE:" + message);
            }

            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            if (message != null)
            {
                Console.WriteLine("AFTER:" + message);
            }
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
        }
        public void Comparisons(string message)
        {

        }
    }
}
