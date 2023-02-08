using System;

namespace SnakesAndLadders
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakesAndLadders");

            var game = new Game();

            var dice = new Dice();
            Game.EnterPlayersInfo(game, Game.NumberOfPlayers());

            bool gameFinished = false;

            while (!gameFinished)
            {
                Console.WriteLine("-----------SCORES-----------");
                game.ShowScores();
                Console.WriteLine("----------------------------");

                var actualPlayer = game.NextTurn();

                Console.WriteLine("Turn of player " + actualPlayer.Id + ":" + actualPlayer.Name);
                Console.WriteLine("Press ENTER to roll the die:");
                Console.ReadLine();

                var moves = dice.RollDie();
                Console.WriteLine("Nice! Move " + moves + " steps");
                actualPlayer.Move(moves);

                if (actualPlayer.HasWon)
                {
                    gameFinished = true;
                    Console.WriteLine("The winner is player " + actualPlayer.Id + ":" + actualPlayer.Name);
                }
                else
                    game.Add(actualPlayer);
            }

            Console.WriteLine("Press enter to close the game");
            Console.ReadLine();
        }
    }
}
