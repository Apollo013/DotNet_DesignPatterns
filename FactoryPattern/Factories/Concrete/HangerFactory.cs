using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;

namespace FactoryPattern.Factories.Concrete
{
    public class HangerFactory : AbstractVehicleFactory
    {
        public override void Create()
        {
            Vehicles.Add(new CargoPlane());
            Vehicles.Add(new PassengerPlane());
        }
    }
}
