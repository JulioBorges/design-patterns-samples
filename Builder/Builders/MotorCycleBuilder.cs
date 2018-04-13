using Builder.Builders.Contract;
using Builder.Entities;

namespace Builder
{
    class MotorCycleBuilder : AVehicleBuilder
    {
        public MotorCycleBuilder()
            : base(new Vehicle("MotorCycle"))
        {
        }

        public override void BuildFrame()
        {
            _vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "0";
        }
    }
}