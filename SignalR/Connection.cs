using DoubleRummyEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleRummy.SignalR
{
    public class Connection
    {
        public Connection(string connectionId, string displayName, Player player = null)
        {
            ConnectionId = connectionId;
            DisplayName = displayName;
            Player = player ?? new Player { Balance = RoundDefaults.StartingBalance };
        }

        public string ConnectionId { get; set; }
        public string DisplayName { get; set; }
        public Player Player { get; set; }
    }
}
