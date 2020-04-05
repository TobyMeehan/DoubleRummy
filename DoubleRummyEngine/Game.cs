using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummyEngine
{
    public class Game
    {
        public Game(List<Player> players, List<Round> rounds)
        {
            Players = players;
            Rounds = rounds;
        }

        public List<Player> Players { get; set; }
        public List<Round> Rounds { get; set; }
        public int CurrentRoundId { get; set; }

        public Round CurrentRound => Rounds[CurrentRoundId];
    }
}
