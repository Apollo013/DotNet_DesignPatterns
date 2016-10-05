using BuilderPattern.Entities;

namespace BuilderPattern.Builders.Abstract
{
    /// <summary>
    /// Abstract class for building vehicles
    /// </summary>
    public abstract class VehicleBuilder
    {
        private Vehicle vehicle;

        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public VehicleBuilder(string vehicleType)
        {
            vehicle = new Vehicle(vehicleType);
        }

        // Abstract methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
