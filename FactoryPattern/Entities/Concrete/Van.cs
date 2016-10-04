using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class Van : IVehicle
    {
        public string Name
        {
            get
            {
                return "Van";
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
