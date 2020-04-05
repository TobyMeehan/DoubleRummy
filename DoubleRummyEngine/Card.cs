using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Card
    {
        public Card()
        {

        }
        public Card(Suit suit , int value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; set; }
        public int Value { get; set; }

        public static Card Joker
        {
            get
            {
                return new Card { Suit = Suit.Joker };
            }
        }
    }

    public enum Suit
    {
        Spades = 0,
        Clubs = 1,
        Hearts = 2,
        Diamonds = 3,
        Joker = 4
    }

    public enum Value
    {
        Ace = 1,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
