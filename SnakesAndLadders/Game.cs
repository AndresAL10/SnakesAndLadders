using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public interface IGame
    {
        void Add(Player player);
        Player NextTurn();
        void ShowScores();
    }
    public class Game : IGame
    {
        public readonly Queue<Player> players;

        public Game()
        {
            players = new Queue<Player>();
        }
        public void Add(Player player)
        {
            players.Enqueue(player);
        }

        public Player NextTurn()
        {
            return players.Dequeue();
        }

        public void ShowScores()
        {
            foreach (var player in players)
            {
                Console.WriteLine("->  Player number " + player.Id + " " + player.Name + ": " + player.Position + " square");
            }
        }

        public static int NumberOfPlayers()
        {
            int numberOfPlayers;

            do
            {
                Console.WriteLine("Enter a valid number of players (2 MIN):");
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            } while (numberOfPlayers < 2);

            return numberOfPlayers;
        }

        public static void EnterPlayersInfo(Game game, int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter a name for the player " + (i + 1) + ":");
                var newPlayer = new Player(i + 1, Console.ReadLine());
                game.Add(newPlayer);
            }
        }
    }
}
