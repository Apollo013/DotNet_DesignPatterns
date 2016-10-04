using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class PassengerPlane : IVehicle
    {
        public string Name
        {
            get
            {
                return "Passenger Plane";
            }
        }

        public void SwithchOn()
        {
            Console.WriteLine($"The {Name} is flying");
        }

        public void SwitchOff()
        {
            Console.WriteLine($"The {Name} has landed");
        }
    }
}
