using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13CardLib;

namespace Ch13CardClient
{
    public class Player
    {
        public string Name { get; private set; }
        public Cards PlayHand { get; private set; }
        private Player() { }
        public Player(string name)
        {
            Name = name;
            PlayHand = new Cards();
        }
        public bool HasWon()
        {
            // returns true if all the cards in the player’s hand
            // are the same suit(a simple winning condition,
            // but that doesn’t matter too much).

            // Exercise:
            // Can you think of a way that you could make this code more efficient,
            // perhaps without having to examine every card in the player’s hand
            // every time this method is called ?

            bool won = true;
            Suit match = PlayHand[0].suit;
            for (int i = 1; i < PlayHand.Count; i++)
            {
                won &= PlayHand[i].suit == match;
                if (won == false) // if false, immediately return 
                {
                    return won;
                }
            }
            return won;
        }
    }
}
