namespace PlatformerGame
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsJumping { get; set; }
        public int JumpHeight { get; set; } = 1;
        public int JumpCounter { get; set; }

        public void MoveLeft()
        {
            X--;
        }

        public void MoveRight()
        {
            X++;
        }

        public void Jump()
        {
            if (!IsJumping)
            {
                IsJumping = true;
                JumpCounter = JumpHeight;
            }
        }

    }
}
