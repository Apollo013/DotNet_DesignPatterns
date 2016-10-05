using BuilderPattern.Builders.Abstract;

namespace BuilderPattern.Directors
{
    /// <summary>
    /// Shop for building vehicles
    /// </summary>
    public class VehicleManufacturer
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            // These are the steps required to build a vehicle
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
