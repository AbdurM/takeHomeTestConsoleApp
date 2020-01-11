using System;
using RoverController.Extensions;
using RoverController.Interfaces;

namespace RoverController
{
    class Program
    {
        static void Main()
        {
            IVehicle rover = new Rover(1, 2, Direction.N);
            string input;

            do
            {
                Console.WriteLine($"\n\nCurrent rover postion: {rover}");
                Console.WriteLine("Please enter the movement info(Only M, L or R) or E to exit:");

                input = Console.ReadLine().ToUpper();

                if(input == "E")
                   return;
               
                var charArray = input.ToCharArray();

                foreach (var character in charArray)
                {
                    switch (character.ToMovementEnum())
                    {
                        case Movement.Move:
                            rover.Move();
                            break;
                        case Movement.Left:
                            rover.TurnLeft();
                            break;
                        case Movement.Right:
                            rover.TurnRight();
                            break;
                        default:
                            throw new Exception("Movement not identified");
                    }
                }

                Console.WriteLine(rover);

            } while (input.ToUpper() != "E");
         }
        
    }
}
