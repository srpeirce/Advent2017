using System.Collections.Generic;

namespace Day3
{
    public class MemoryBlock
    {
        private enum Direction { Left, Right, Up, Down }

        public MemoryCoords Coords { get; private set; }
        public int Address { get; private set; }
        public ulong Value { get; private set; }

        private Direction _direction;
        private int _delta;

        private MemoryBlock() { }

        public static MemoryBlock First()
        {
            return new MemoryBlock
            {
                Address = 1,
                _delta = 1,
                _direction = Direction.Right
            };
        }

        public MemoryBlock Next()
        {
            var newDelta = _delta;
            var newCoords = new MemoryCoords(Coords.X, Coords.Y);
            var newDirection = _direction;
            
            switch (_direction)
            {
                case Direction.Right:
                    newCoords = newCoords.MoveX(1);
                    if (newCoords.X == 0) ++newDelta;
                    else if (newCoords.X == newDelta) newDirection = Direction.Up;
                    break;
                case Direction.Up:
                    newCoords = newCoords.MoveY(1);
                    if (newCoords.Y == newDelta) newDirection = Direction.Left;
                    break;
                case Direction.Left:
                    newCoords = newCoords.MoveX(-1);
                    if (newCoords.X == newDelta * -1) newDirection = Direction.Down;
                    break;
                case Direction.Down:
                    newCoords = newCoords.MoveY(-1);
                    if (newCoords.Y == newDelta * -1) newDirection = Direction.Right;
                    break;
            }

            return new MemoryBlock
            {
                Address = this.Address + 1,
                Coords = newCoords,
                _direction = newDirection,
                _delta = newDelta
            };
        }

        public MemoryBlock WithValue(ulong value)
        {
            return new MemoryBlock
            {
                Value = value,
                Address = this.Address,
                Coords = this.Coords,
                _delta = this._delta,
                _direction = this._direction
            };
        }

        public int CalculateSteps()
        {
            var xSteps = Coords.X > 0 ? Coords.X : Coords.X * -1;
            var YSteps = Coords.Y > 0 ? Coords.Y : Coords.Y * -1;
            return xSteps + YSteps;
        }
    }
}
