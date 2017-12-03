using System.Collections.Generic;

namespace Day3
{
    public struct MemoryCoords
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public MemoryCoords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public MemoryCoords MoveX(int moveBy)
        {
            return new MemoryCoords(X + moveBy, Y);
        }

        public MemoryCoords MoveY(int moveBy)
        {
            return new MemoryCoords(X, Y + moveBy);
        }

        public List<MemoryCoords> GetTouchingCoords()
        {
            var touchingCoords = new List<MemoryCoords>
            {
                this, // Self

                MoveX(1), // Right
                MoveX(1).MoveY(1), // Top Right
                MoveX(1).MoveY(-1), // Bottom Right

                MoveX(-1), // Left
                MoveX(-1).MoveY(1), // Top Left
                MoveX(-1).MoveY(-1), // Bottom Left

                MoveY(1), // Above
                MoveY(-1) // Below
            };

            return touchingCoords;
        }
    }
}
