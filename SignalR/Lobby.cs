using DoubleRummyEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleRummy.SignalR
{
    public class Lobby
    {
        public Lobby(string displayName, int size)
        {
            Players.Add(displayName, new Player());
            Size = size;
        }

        public Game Game { get; set; }
        public Dictionary<string, Player> Players { get; set; }
        public Player Player { get; set; }
        public int Size { get; set; }

        public bool TryJoin(string displayName, out string message)
        {
            if (Players.Count < Size)
            {
                if (!Players.ContainsKey(displayName))
                {
                    Players.Add(displayName, new Player());
                    message = "Successfully joined lobby.";
                    return true;
                }
                else
                {
                    message = "A player has already joined with that display name";
                }
            }
            else
            {
                message = "The lobby is full.";
            }

            return false;
        }
    }
}
