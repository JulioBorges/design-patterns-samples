using Builder.Builders.Contract;
using Builder.Entities;

namespace Builder
{
    class CarBuilder : AVehicleBuilder
    {
        public CarBuilder()
            : base(new Vehicle("Car"))
        {
        }

        public override void BuildFrame()
        {
            _vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }
}