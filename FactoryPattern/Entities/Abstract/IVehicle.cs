namespace FactoryPattern.Entities.Abstract
{
    public interface IVehicle
    {
        string Name { get; }
        void SwithchOn();
        void SwitchOff();
    }
}
