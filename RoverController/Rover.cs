using System;
using System.Drawing;
using RoverController.Interfaces;

namespace RoverController
{
    public class Rover: IVehicle
    {
        #region Properties

        int X { get; set; }
        int Y { get; set; }
        Direction Direction { get; set; }

        #endregion

        #region constructors

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        #endregion

        #region Movement related methods

        public void Move()
        {
            switch (Direction)
            {
                case Direction.N:
                    Y++;
                    break;
                case Direction.S:
                    if (Y > 0)
                        Y--;
                    break;
                case Direction.E:
                    X++;
                    break;
                case Direction.W:
                    if (X > 0)
                        X--;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.N;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
            }
        }

        #endregion

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
    }
}
