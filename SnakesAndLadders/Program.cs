using System;

namespace SnakesAndLadders
{
    public static class Program
    {
        private static int NumberOfPlayers()
        {
            int numberOfPlayers;

            do
            {
                Console.WriteLine("Enter a valid number of players (2 MIN):");
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            } while (numberOfPlayers < 2);

            return numberOfPlayers;
        }
        private static void EnterPlayersInfo(Game game, int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter a name for the player " + (i + 1) + ":");
                var newPlayer = new Player(i + 1, Console.ReadLine());
                game.Add(newPlayer);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SnakesAndLadders");

            var game = new Game();
            var dice = new Dice();
            EnterPlayersInfo(game, NumberOfPlayers());

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
