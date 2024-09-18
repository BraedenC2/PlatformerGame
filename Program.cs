namespace PlatformerGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            Level level = new Level();
            Game game = new Game();

            for (int y = 0; y < level.Map.GetLength(0); y++)
            {
                for (int x = 0; x < level.Map.GetLength(1); x++)
                {
                    if (level.Map[y, x] == 'P')
                    {
                        player.X = x;
                        player.Y = y;
                    }
                }
            }


            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        player.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        player.MoveRight();
                        break;
                    case ConsoleKey.Spacebar:
                        player.Jump();
                        break;
                }

                if (player.IsJumping)
                {
                    player.Y--;
                    player.JumpCounter--;

                    if (player.JumpCounter == 0)
                    {
                        player.IsJumping = false;
                    }
                }

                if (!player.IsJumping)
                {
                    player.Y++; 
                }

                Console.Clear();

                for (int y = 0; y < level.Map.GetLength(0); y++)
                {
                    for (int x = 0; x < level.Map.GetLength(1); x++)
                    {
                        if (x == player.X && y == player.Y)
                        {
                            Console.Write("@"); 
                        }
                        else
                        {
                            Console.Write(level.Map[y, x]);
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}