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
    }
}
