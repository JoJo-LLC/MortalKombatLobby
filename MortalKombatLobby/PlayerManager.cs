using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombatLobby
{
    public class PlayerManager
    {
        private List<string> loggedInPlayers;

        public PlayerManager()
        {
            loggedInPlayers = new List<string>();
        }

        // Method to check if a username is unique and log in the player
        public bool LoginPlayer(string username)
        {
            if (loggedInPlayers.Contains(username))
            {
                return false;  // Username already exists
            }

            loggedInPlayers.Add(username);
            return true;  // Login successful
        }

        // Method to log out a player
        public void LogoutPlayer(string username)
        {
            loggedInPlayers.Remove(username);
        }

        // Method to return the list of logged-in players
        public List<string> GetLoggedInPlayers()
        {
            return loggedInPlayers;
        }
    }
}

