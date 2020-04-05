using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Round
    {
        public Round(params Validator[] validators)
        {
            Validator = new RoundValidator(validators);
            Deck = new List<Card>().FillDeck();
        }

        public List<Card> Deck { get; set; }
        public List<Card> Discard { get; set; }
        public RoundValidator Validator { get; set; }
        public List<List<Card>> Melds { get; set; }
        public Game Game { get; set; }

    }
}
