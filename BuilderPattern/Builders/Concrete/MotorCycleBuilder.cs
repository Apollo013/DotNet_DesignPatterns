using BuilderPattern.Builders.Abstract;

namespace BuilderPattern.Builders.Concrete
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder() : base("MotorCycle")
        { }

        public override void BuildFrame()
        {
            Vehicle["Frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["Engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["Wheels"] = "2";
        }

        public override void BuildDoors()
        {
            Vehicle["Doors"] = "0";
        }
    }
}
