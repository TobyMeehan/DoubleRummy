using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Card
    {
        public Suit Suit { get; set; }
        public int Rank { get; set; }
    }

    public enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds,
        Joker
    }
}
