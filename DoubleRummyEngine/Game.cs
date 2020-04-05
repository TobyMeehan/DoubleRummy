using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Game
    {
        public List<Round> Rounds { get; set; }
        public int CurrentRoundId { get; set; }

        public Round CurrentRound => Rounds[CurrentRoundId];
    }
}
