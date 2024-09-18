using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
#: Represents a solid block (ground or walls)
.: Represents empty space
P: Represents the player's starting position
C: Represents a coin
 */

namespace PlatformerGame
{
    public class Level
    {
        public char[,] Map { get; private set; }

        public Level()
        {
            Map = new char[,] {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
            { '#', '.', '.', 'P', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'C', '.', '.', '#' },
            { '#', '.', '.', '.', '.', '#', '#', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '.', '#' },
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
        };
        }

        public bool IsSolid(int x, int y)
        {
            if (x < 0 || x >= Map.GetLength(1) || y < 0 || y >= Map.GetLength(0))
            {
                return true;
            }

            return Map[y, x] == '#'; 
        }

    }
}
