using BuilderPattern.Builders.Abstract;
using BuilderPattern.Builders.Concrete;
using BuilderPattern.Directors;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder vehicleBuilder;
            var manufacturer = new VehicleManufacturer();

            vehicleBuilder = new CarBuilder();
            manufacturer.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            vehicleBuilder = new MotorCycleBuilder();
            manufacturer.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            vehicleBuilder = new BusBuilder();
            manufacturer.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();
        }
    }
}
