using DoubleRummyEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleRummy.SignalR
{
    public class Lobby
    {
        public Lobby(string connectionId, string displayName, int size)
        {
            Players.Add(new Connection(connectionId, displayName));
            Size = size;
        }

        public Game Game { get; set; }
        public List<Connection> Players { get; set; } = new List<Connection>();
        public Player Player { get; set; }
        public int Size { get; set; }

        public bool TryJoin(string connectionId, string displayName, out string message)
        {
            if (Players.Count < Size)
            {
                if (!Players.Any(p => p.DisplayName == displayName))
                {
                    Players.Add(new Connection(connectionId, displayName));
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

        public void InitGame()
        {
            Game = new Game(Players.Select(p => p.Player).ToList(), RoundDefaults.DoubleRummy);
        }

        /// <summary>
        /// Starts the next turn and returns the next connection to be called
        /// </summary>
        /// <returns></returns>
        public Connection Next()
        {

        }
    }
}
