using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;

namespace FactoryPattern.Factories.Concrete
{
    public class ShowroomFactory : AbstractVehicleFactory
    {
        public override void Create()
        {
            Vehicles.Add(new Car());
            Vehicles.Add(new Van());
        }
    }
}
