using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Round
    {
        public List<Player> Players { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> Discard { get; set; }

        public delegate bool Validate(List<Card> meld, Card card);
        public Func<List<Card>, Card, bool> Validator { get; set; }
        public List<List<Card>> Melds { get; set; }

    }
}
