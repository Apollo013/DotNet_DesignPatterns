using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class CargoPlane : IVehicle
    {
        public string Name
        {
            get
            {
                return "Cargo Plane";
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
