using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestMove_PlayerIsCreated_InitialPositionIs1()
        {
            var player = new Player(1, "PlayerName");
            Assert.IsTrue(player.Position == 1);
        }

        [TestMethod]
        public void TestMove_PlayerIsCreatedAndMoves3Steps_ActualPositionIs4()
        {
            var player = new Player(1, "PlayerName");
            player.Move(3);
            Assert.IsTrue(player.Position == 4);
        }

        [TestMethod]
        public void TestMove_PlayerIsCreatedAndMoves3StepsAndThen4Steps_ActualPositionIs8()
        {
            var player = new Player(1, "PlayerName");
            player.Move(3);
            player.Move(4);
            Assert.IsTrue(player.Position == 8);
        }

        [TestMethod]
        public void TestMove_PlayerIsIn97SquareAndMoves3Steps_HasWonIsTrue()
        {
            var player = new Player(1, "PlayerName");
            player.Position = 97;
            player.Move(3);
            Assert.IsTrue(player.HasWon);
        }

        [TestMethod]
        public void TestMove_PlayerIsIn97SquareAndMoves4Steps_HasWonIsFalse()
        {
            var player = new Player(1, "PlayerName");
            player.Position = 97;
            player.Move(4);
            Assert.IsFalse(player.HasWon);
        }
    }
}
