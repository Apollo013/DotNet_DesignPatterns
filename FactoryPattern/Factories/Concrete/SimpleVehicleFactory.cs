using FactoryPattern.Entities.Abstract;
using FactoryPattern.Entities.Concrete;

namespace FactoryPattern.Factories.Concrete
{
    public class SimpleVehicleFactory
    {
        public static IVehicle Create(string type)
        {
            switch (type)
            {
                case "Car":
                    return new Car();
                case "SailingShip":
                    return new SailingShip();
                case "CargoPlane":
                    return new CargoPlane();
                case "PassengerPlane":
                    return new PassengerPlane();
                case "SpeedBoat":
                    return new SpeedBoat();
                case "Van":
                    return new Van();
                default:
                    return new UnknownVehicle(); // Demonstration of 'Null Object' pattern
            }
        }
    }
}
