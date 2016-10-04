using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class SpeedBoat : IVehicle
    {
        public string Name
        {
            get
            {
                return "Speed Boat";
            }
        }

        public void SwithchOn()
        {
            Console.WriteLine($"The {Name} is cruising");
        }

        public void SwitchOff()
        {
            Console.WriteLine($"The {Name} has docked");
        }
    }
}
