using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleRummy.SignalR
{
    public class GameHub : Hub<IGameClient>
    {
        private readonly Dictionary<string, Lobby> _lobbies;

        public GameHub(Dictionary<string, Lobby> lobbies)
        {
            _lobbies = lobbies;
        }

        public async Task JoinLobby(string key, string displayName)
        {
            if (_lobbies.ContainsKey(key))
            {
                Lobby lobby = _lobbies[key];

                if (lobby.TryJoin(displayName, out string reason))
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, key);
                    await Clients.Caller.SuccessLobbyJoin(lobby);
                    await Clients.GroupExcept(key, Context.ConnectionId).PlayerJoinedLobby(lobby.Players[displayName]);
                }
                else
                {
                    await Clients.Caller.FailedLobbyJoin(reason);
                }
            }
            else
            {
                await Clients.Caller.FailedLobbyJoin("Lobby not found.");
            }
        }

        public Task CreateLobby(string displayName, string key, int size)
        {
            if (!_lobbies.ContainsKey(key))
            {
                Lobby lobby = new Lobby(displayName, size);
                _lobbies.Add(key, lobby);
                return Clients.Caller.SuccessLobbyJoin(lobby);
            }
            else
            {
                return Clients.Caller.FailedLobbyJoin("Lobby already exists.");
            }
        }
    }
}
