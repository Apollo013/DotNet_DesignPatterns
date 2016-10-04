using FactoryPattern.Entities.Abstract;

namespace FactoryPattern.Factories.Abstract
{
    public interface IReflectionVehicleFactory
    {
        IVehicle Create(string type);
    }
}
