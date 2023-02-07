using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SnakesAndLadders.Tests
{
    [TestClass]
    public class DiceTest
    {
        readonly IDice die = new Dice();

        [TestMethod]
        public void TestRollDie_ARandomNumberIsGenerated_RandomNumberIsBetween1And6()
        {
            int randomNumber = die.RollDie();

            Assert.IsTrue(randomNumber > 0 && randomNumber < 7);
        }

        [TestMethod]
        public void TestRollDie_ARandomNumberIsGenerated_RandomNumberIsNotOutOfBounds1And6()
        {
            int randomNumber = die.RollDie();

            Assert.IsFalse(randomNumber < 1 && randomNumber > 6);
        }

        [TestMethod]
        public void TestRollDie_RandomNumbersAreGenerated_ObtainingTheSameProbability()
        {
            int[] exists = new int[10];
            
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                int randomNumber = die.RollDie();
                    exists[randomNumber]++;
            }

            Assert.IsFalse(exists[0]>0);
            Assert.IsTrue(exists[1] > 155);
            Assert.IsTrue(exists[2] > 155);
            Assert.IsTrue(exists[3] > 155);
            Assert.IsTrue(exists[4] > 155);
            Assert.IsTrue(exists[5] > 155);
            Assert.IsTrue(exists[6] > 155);
            Assert.IsFalse(exists[7] > 0);
            Assert.IsFalse(exists[8] > 0);
            Assert.IsFalse(exists[9] > 0);

        }
    }
}
