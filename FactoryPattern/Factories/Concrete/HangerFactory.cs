using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;

namespace FactoryPattern.Factories.Concrete
{
    public class HangerFactory : AbstractVehicleFactory
    {
        public override void Fill()
        {
            Vehicles.Add(new CargoPlane());
            Vehicles.Add(new PassengerPlane());
        }
    }
}
