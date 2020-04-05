using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class RoundValidator
    {
        public RoundValidator(params Validator[] validators)
        {
            Validators = new List<Validator>(validators);
        }

        public List<Validator> Validators { get; set; }
        public int RequiredMelds => Validators.Count;
        public bool Validate(List<Card> meld)
        {

        }
    }

    public delegate bool Validator(List<Card> cards);
}
