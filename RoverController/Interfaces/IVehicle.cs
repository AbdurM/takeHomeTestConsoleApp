using System;
namespace RoverController.Interfaces
{
    public interface IVehicle
    {
        void Move();
        void TurnLeft();
        void TurnRight();
    }
}
