using BuilderPattern.Builders.Abstract;

namespace BuilderPattern.Builders.Concrete
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder() : base("Car")
        { }

        public override void BuildFrame()
        {
            Vehicle["Frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["Engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["Wheels"] = "4";
        }

        public override void BuildDoors()
        {
            Vehicle["Doors"] = "4";
        }
    }
}
