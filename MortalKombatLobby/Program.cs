using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombatLobby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();

            Console.WriteLine("Welcome to Mortal Kombat Lobby!");

            while (true)
            {
                Console.WriteLine("\nEnter your username to log in:");
                string username = Console.ReadLine();

                if (playerManager.LoginPlayer(username))
                {
                    Console.WriteLine($"Welcome, {username}!");
                    Console.WriteLine("Players currently in the lobby: " + string.Join(", ", playerManager.GetLoggedInPlayers()));
                }
                else
                {
                    Console.WriteLine("Username already exists. Please choose another one.");
                }

                Console.WriteLine("\nDo you want to log out? (yes/no)");
                string logoutResponse = Console.ReadLine();
                if (logoutResponse.ToLower() == "yes")
                {
                    playerManager.LogoutPlayer(username);
                    Console.WriteLine($"{username} has logged out.");
                }
            }
        }
    }
}
