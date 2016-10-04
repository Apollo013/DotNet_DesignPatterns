using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;

namespace FactoryPattern.Factories.Concrete
{
    public class ShowroomFactory : AbstractVehicleFactory
    {
        public override void Fill()
        {
            Vehicles.Add(new Car());
            Vehicles.Add(new Van());
        }
    }
}
