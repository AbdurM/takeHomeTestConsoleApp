using System;
namespace RoverController.Extensions
{
    public static class CharExtensions
    {
        public static Movement ToMovementEnum(this char c)
        {
            return (char.ToUpper(c)) switch
            {
                'M' => Movement.Move,

                'L' => Movement.Left,

                'R' => Movement.Right,

                _ => throw new Exception("\n\nUnrecongnised movement. Please use only M, L or R\n\n"),
            };
        }
    }
}
