using BuilderPattern.Builders.Abstract;

namespace BuilderPattern.Builders.Concrete
{
    public class BusBuilder : VehicleBuilder
    {
        public BusBuilder() : base("Bus")
        { }

        public override void BuildFrame()
        {
            Vehicle["Frame"] = "Bus Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["Engine"] = "5000 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["Wheels"] = "6";
        }

        public override void BuildDoors()
        {
            Vehicle["Doors"] = "2";
        }
    }
}
