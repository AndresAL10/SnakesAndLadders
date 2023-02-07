using System;

namespace SnakesAndLadders
{
    public interface IDice
    {
        int RollDie();
    }
    public class Dice : IDice
    {
        public int RollDie()
        {
            var rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
