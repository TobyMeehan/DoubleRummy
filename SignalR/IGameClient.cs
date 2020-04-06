using DoubleRummyEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoubleRummy.SignalR
{
    public interface IGameClient
    {
        Task SuccessLobbyJoin(Lobby lobby);
        Task PlayerJoinedLobby(Player player);
        Task FinalPlayerJoined();
        Task FailedLobbyJoin(string reason);
        Task StartGame(Game game);
        Task TakeTurn();
    }
}
