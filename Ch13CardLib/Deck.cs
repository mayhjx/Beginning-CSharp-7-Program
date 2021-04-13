﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch13CardLib
{
    public class Deck : ICloneable
    {
        public event EventHandler lastCardDrawn;
        //private Card[] cards;
        private Cards cards = new Cards();

        public Deck()
        {
            //cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //cards[suitVal * 13 + rankVal - 1] =
                    //new Card((Suit)suitVal,
                    //(Rank)rankVal);
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (lastCardDrawn != null))
                {
                    lastCardDrawn(this, EventArgs.Empty);
                }
                return cards[cardNum];
            }
            else
            {
                throw new CardOutOfRangeException(cards.Clone() as Cards);
            }
        }

        public void Shuffle()
        {
            //Card[] newDeck = new Card[52];
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            for (int i = 0; i < 52; i++)
            {
                //int destCard = 0;
                int sourceCard = 0;
                bool foundCard = false;
                // 找到下一张还未被洗牌的牌
                while (foundCard == false)
                {
                    //destCard = sourceGen.Next(52);
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[sourceCard] = true;
                //newDeck[sourceCard] = cards[i];
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }

        private Deck(Cards newCards) => cards = newCards;

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }
    }
}