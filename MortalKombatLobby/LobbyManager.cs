using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombatLobby
{
    public class LobbyManager
    {
        private Dictionary<string, List<string>> lobbies;  // Stores the lobbies and their players

        public LobbyManager()
        {
            lobbies = new Dictionary<string, List<string>>();
        }

        // Create a new lobby room
        public bool CreateLobby(string lobbyName)
        {
            if (lobbies.ContainsKey(lobbyName))
            {
                return false;  // Lobby already exists
            }

            lobbies.Add(lobbyName, new List<string>());
            return true;
        }

        // Join an existing lobby room
        public bool JoinLobby(string lobbyName, string username)
        {
            if (!lobbies.ContainsKey(lobbyName))
            {
                return false;  // Lobby doesn't exist
            }

            lobbies[lobbyName].Add(username);
            return true;
        }

        // Leave a lobby room
        public bool LeaveLobby(string lobbyName, string username)
        {
            if (!lobbies.ContainsKey(lobbyName) || !lobbies[lobbyName].Contains(username))
            {
                return false;  // Lobby or player not found
            }

            lobbies[lobbyName].Remove(username);
            return true;
        }

        // Get a list of players in a lobby room
        public List<string> GetPlayersInLobby(string lobbyName)
        {
            if (!lobbies.ContainsKey(lobbyName))
            {
                return null;  // Lobby doesn't exist
            }

            return lobbies[lobbyName];
        }

        // Get all the existing lobbies
        public Dictionary<string, List<string>> GetAllLobbies()
        {
            return lobbies;
        }
    }
}
