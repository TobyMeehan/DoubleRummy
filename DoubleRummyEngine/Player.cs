using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Player
    {
        public int Balance { get; set; }
        public List<Card> Hand { get; set; }

        public void Discard(Card card)
        {
            Hand.Remove(card);
        }
    }
}
