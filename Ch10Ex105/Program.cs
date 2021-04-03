using System;
using Ch10CardLib;

namespace Ch10Ex105
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            for (int i =  0; i < 47; i += 5)
            {
                Card[] cards = new Card[5];
                for (int time = 0; time < 5; time++)
                {
                    Console.WriteLine($"{i+time} {myDeck.GetCard(i+time)}");
                    cards[time] = myDeck.GetCard(i + time);
                }
                
                if(cards[0].suit == cards[1].suit &&
                    cards[1].suit == cards[2].suit &&
                    cards[2].suit == cards[3].suit &&
                    cards[3].suit == cards[4].suit)
                {
                    Console.Write($"{cards[0].ToString()} " +
                        $"{cards[1].ToString()} " +
                        $"{cards[2].ToString()} " +
                        $"{cards[3].ToString()} " +
                        $"{cards[4].ToString()} Flush!");
                    return;
                }

            }

            Console.WriteLine("No flush.");
        }
    }
}
