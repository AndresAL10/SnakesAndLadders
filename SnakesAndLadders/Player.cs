namespace SnakesAndLadders
{
    public interface IPlayer
    {
        void Move(int moves);
    }
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; }
        public int Position { get; set; }
        public bool HasWon { get; set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Position = 1;
            HasWon = false;
        }
        public void Move(int moves)
        {
            if (Position + moves < 101)
                Position += moves;

            if (Position == 100)
                HasWon = true;
        }
    }
}
