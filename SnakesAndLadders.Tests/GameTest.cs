using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestAdd_ANewPlayerIsCreatedAndAdded_TotalPlayersEqualsTo1()
        {
            var player = new Player(1, "PlayerName");
            var game = new Game();

            game.Add(player);

            Assert.IsTrue(game.players.Count == 1);
        }

        [TestMethod]
        public void TestAdd_2NewPlayersAreCreatedAndAdded_TotalPlayersEqualsTo2()
        {
            var player1 = new Player(1, "PlayerName1");
            var player2 = new Player(2, "PlayerName2");
            var game = new Game();

            game.Add(player1);
            game.Add(player2);

            Assert.IsTrue(game.players.Count == 2);
        }

        [TestMethod]
        public void TestNextTurn_NextPlayerIsSelected_Player1Returned()
        {
            var player1 = new Player(1, "PlayerName1");
            var player2 = new Player(2, "PlayerName2");
            var game = new Game();

            game.Add(player1);
            game.Add(player2);

            var player = game.NextTurn();

            Assert.IsTrue(player.Id == 1);
        }
    }
}
