using System;

namespace CardShuffler
{
    public enum Suits {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public enum Ranks
    {
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }

    class Program
    {
        static void Main(string[] args)
        {
            CardDeck firstDeck;
            CardDeck secondDeck;
            CardDeck thirdDeck;

            // 1.
            // Create a deck of cards, named 'firstDeck'
            // Fill the deck with cards
            // Printout the deck of cards as is. 
            firstDeck = new CardDeck("firstDeck");
            firstDeck.GenerateCards();
            firstDeck.PrintCards();


            // 2.
            // Shuffle the deck of cards
            // Printout the deck of cards as is.
            firstDeck.Shuffle();
            firstDeck.PrintCards();


            // 3.
            // Put the deck of cards back into order: Spades, Hearts, Diamonds, Clubs
            // Printout the deck of cards as is.
            firstDeck.OrderCards();
            firstDeck.PrintCards();

            // 4.
            // Shuffle the deck of cards and print it out.
            // Peak at the first three cards of the deck, and print them out.
            // Peak at the last three cards of the deck, and print them out.
            firstDeck.Shuffle();
            firstDeck.PrintCards();
            firstDeck.DealCardFromTop(3);
            firstDeck.DealCardFromBottom(3);

            // 5.
            // Take the first card in the deck and put it in the middle of the deck.            
            // Take the last card in the deck, and put it in the middle of the deck.
            // Print out the deck of cards
            firstDeck.MoveCardToMiddleOfDeck(0);
            firstDeck.MoveCardToMiddleOfDeck(firstDeck.DeckCount() - 1);
            firstDeck.PrintCards();

            // 6.
            // Create two more decks of cards: secondDeck, thirdDeck
            // Fill the decks with cards.
            // Shuffle both decks
            // Find the intersection of both decks: 
            //      where the card suit and value are in the same position in the deck.
            // Print out the results
            // EXAMPLE:
            // Position 1: Two of Hearts, Three of Diamonds. No match.
            // Position 2: Ace of Spades, Ace of Spades, Match found.
            // Position 3: Five of Clubs, Eight of Hearts. No Match.
            // Position 4: King of Clubs, King of Clubs. Match found.
            secondDeck = new CardDeck("secondDeck");
            thirdDeck = new CardDeck("thirdDeck");
            secondDeck.GenerateCards();
            thirdDeck.GenerateCards();
            secondDeck.Shuffle();
            thirdDeck.Shuffle();
            secondDeck.Compare(thirdDeck);

        }
    }
}
