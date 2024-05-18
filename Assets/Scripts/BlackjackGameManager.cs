using System.Collections;
using System.Collections.Generic;
using CardShuffler;
using UnityEngine;

public class BlackjackGameManager : GameManager
{
    // Start is called before the first frame update
    void Start()
    {
        _theDeck = new CardDeck("BlackjackDeck");
        _theDeck.GenerateCards();
        _theDeck.Shuffle();
        _theDeck.DealCardFromTop();
        //C'est la vie. The below loop prolly goes in a Coroutine/State Machine
        // Place Bets (minBet, maxBet, playerBet)
        // WE CAN ADD OTHER PLAYERS ONCE WE GET THE BASIC 1v1 LOOP DONE
        // Deal Cards (ADD SPLITTING, AND DOUBLING DOWN LATER;)
        // Use 'Player' class to hold refs to Dealer and User Hands (list of cards currently held)
        // User HIT/STAY? (UIManager handles input and tells THIS what was selected/what state we in next)
        // Dealer reveals face down card; if dealer.Hand.Sum >= 17, they must STAY, else they HIT; if dealer.HasBlackjack == true, User Loses unless User hasBlackjack or
        //  user.Hand.Sum == 21
        // Handle Dealer.Hand vs User.Hand.
        //  Back to PlaceBets state if User.MoneyLeft > minBet; else, Restart or Quit state
        // If _theDeck.DeckCount < X, go to NewDeck state (lines 11-13)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
