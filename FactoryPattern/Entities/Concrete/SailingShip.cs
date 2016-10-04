using FactoryPattern.Entities.Abstract;
using System;

namespace FactoryPattern.Entities.Concrete
{
    public class SailingShip : IVehicle
    {
        public string Name
        {
            get
            {
                return "Sailing Ship";
            }
        }

        public void SwithchOn()
        {
            Console.WriteLine($"The sails on the {Name} have been hoisted");
        }

        public void SwitchOff()
        {
            Console.WriteLine($"The sails on the {Name} have been lowered");
        }
    }
}
