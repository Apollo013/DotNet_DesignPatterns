using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class Car : IVehicle
    {
        public string Name
        {
            get
            {
                return "Car";
            }
        }

        public void SwithchOn()
        {
            Console.WriteLine($"The {Name} is driving");
        }

        public void SwitchOff()
        {
            Console.WriteLine($"The {Name} is parked");
        }
    }
}
