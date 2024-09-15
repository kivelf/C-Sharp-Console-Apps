using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04Opg5
{
    public enum Suit 
    { 
        Clubs = 0,
        Spades = 1,
        Diamonds = 2,
        Hearts = 3
    }

    public enum CardNumber 
    { 
        Ace = 0,
        Two = 1,
        Three = 2,
        Four = 3,
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12
    }

    delegate bool FilterCardDelegate(Card card);
    internal class Card
    {
        public Suit Suit {  get; set; }
        public CardNumber Number { get; set; }

        public Card(Suit suit, CardNumber number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString() 
        { 
            return Number + " of " + Suit;
        }
    }
}
