using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    // Demonstration of 'Null Object' pattern
    public class UnknownVehicle : IVehicle
    {
        public string Name
        {
            get
            {
                return "Unknown Vehicle";
            }
        }

        public void SwithchOn()
        {
            Console.WriteLine($"The {Name} is doing nothing");
        }

        public void SwitchOff()
        {
            Console.WriteLine($"The {Name} is still doing nothing");
        }
    }
}
