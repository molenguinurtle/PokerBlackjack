using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CardShuffler
{
    public class CardDeck
    {
        protected string Name;
        protected List<Card> Cards;

        public CardDeck(string deckName)
        {
            Name = deckName;
            Cards = new List<Card>();
        }

        /// <summary>
        /// Initializes a list of 52 Cards, one for each possible suit/rank combo
        /// </summary>
        public void GenerateCards()
        {
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int rankIndex = 0; rankIndex < 13; rankIndex++)
                {
                    Cards.Add(new Card((Suits)suitIndex, (Ranks)rankIndex));
                }
            }
        }

        /// <summary>
        /// Prints out the suit/rank combo for each card in the deck starting from the top
        /// </summary>
        public void PrintCards()
        {
            for (int index = 0; index < Cards.Count; index++)
            {
                Cards[index].ToString();
            }
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();

            int n = Cards.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                int r = i + rand.Next(n - i);
                Card temp = Cards[r];
                Cards[r] = Cards[i];
                Cards[i] = temp;
            }
        }

        /// <summary>
        /// Orders the Cards by Suit first, then Rank
        /// </summary>
        public void OrderCards()
        {
            Cards = Cards.OrderBy(c => c.Suit).ThenBy(c => c.Rank).ToList();
        }

        /// <summary>
        /// Moves the given Card from its original position to the middle of the deck
        /// </summary>
        /// <param name="indexOfCard">The original index of the Card to move. Defaults to 0.</param>
        public void MoveCardToMiddleOfDeck(int indexOfCard = 0 )
        {
            if (indexOfCard < Cards.Count)
            {
                Card cardToMove = Cards[indexOfCard];
                Cards.RemoveAt(indexOfCard);
                Cards.Insert(25, cardToMove);
            }
        }

        /// <summary>
        /// Returns the amount of Cards in the deck
        /// </summary>
        /// <returns></returns>
        public int DeckCount()
        {
            return Cards.Count;
        }

        /// <summary>
        /// Compares this CardDeck to another and prints the results on a per-position basis
        /// </summary>
        /// <param name="comparisonDeck">The CardDeck to compare this one to</param>
        public void Compare(CardDeck comparisonDeck)
        {
            if (Cards.Count == comparisonDeck.Cards.Count)
            {
                for (int i = 0; i < Cards.Count; i++)
                {
                    string resultStr = String.Format("Position {0}: {1}, {2}. ",
                             i + 1, Cards[i].ReturnString(), comparisonDeck.Cards[i].ReturnString());
                    bool isMatch = Cards[i].Suit == comparisonDeck.Cards[i].Suit && Cards[i].Rank == comparisonDeck.Cards[i].Rank;
                    resultStr += isMatch ? "Match found." : "No match.";
                    Console.WriteLine(resultStr);
                }
            }
        }


        /// <summary>
        /// Starting from the top of the deck, prints the given number of cards' suit/rank combos
        /// </summary>
        /// <param name="cardAmount">The amount of cards to print. Defaults to 1.</param>
        /// <returns></returns>
        public void DealCardFromTop(int cardAmount = 1)
        {
            for (int i = 0; i < cardAmount; i++)
            {
                Cards[i].ToString();
                //C'est la vie. For Blackjack and Poker, we need to remove the card that was dealt from Cards
            }
        }

        /// <summary>
        /// Starting from the bottom of the deck, prints the given number of cards' suit/rank combos
        /// </summary>
        /// <param name="cardAmount">The amount of cards to print. Defaults to 1.</param>
        /// <returns></returns>
        public void DealCardFromBottom(int cardAmount = 1)
        {
            int startIndex = Cards.Count - 1;
            int endIndex = startIndex - cardAmount;
            for (int i = startIndex; i > endIndex; i--)
            {
                Cards[i].ToString();
            }
        }

        /*
        * Return the CardDeck in order: loweset to highest
        * A, 2, 3, 4, 5, 6, 7, 8, 9, J, Q, K
        */
        public List<Card> InOrder()
        {
            return Cards;
        }

        /*
        * Return the CardDeck in order: highest to loweset
        * K, Q, J, 9, 8, 7, 6, 5, 4, 3, 2, A
        */
        public List<Card> ReverseOrder()
        {
            return Cards;
        }

        ///**
        //* Deal from the middle:
        //* Return a card from the deck.
        //*/
        //public Card DealCardFromMiddle()
        //{
        //    //
        //}
    }
}
