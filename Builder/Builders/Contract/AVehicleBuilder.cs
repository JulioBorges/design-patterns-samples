using Builder.Entities;

namespace Builder.Builders.Contract
{
    abstract class AVehicleBuilder
    {
        protected readonly Vehicle _vehicle;

        public AVehicleBuilder(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}