using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler
{
    public class Card
    {
        public Suits Suit { get; private set; }
        public Ranks Rank { get; private set; }

        public Card(Suits suit, Ranks rank)
        {
            Suit = suit;
            Rank = rank;
        }

        /**
         * Print out the card in format: Rank of Suit
         * Ex: Ace of Spades, Three of Diamonds, Jack of Hearts, etc etc.
         */
        public override string ToString()
        {
            Console.WriteLine(Rank.ToString() + " of " + Suit.ToString());
            return base.ToString();
        }

        public string ReturnString()
        {
            return Rank.ToString() + " of " + Suit.ToString();
        }
    }
}
