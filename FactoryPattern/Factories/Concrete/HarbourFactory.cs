using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;

namespace FactoryPattern.Factories.Concrete
{
    public class HarbourFactory : AbstractVehicleFactory
    {
        public override void Fill()
        {
            Vehicles.Add(new SailingShip());
            Vehicles.Add(new SpeedBoat());
        }
    }
}
