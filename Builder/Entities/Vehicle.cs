using System.Collections.Generic;

namespace Builder.Entities
{
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public override string ToString()
        {
            return
                $"Vehicle Type: {_vehicleType}" +
                $", Frame: {_parts["frame"]}" +
                $", Engine: {_parts["engine"]}" +
                $", Wheels: {_parts["wheels"]}" +
                $", Doors: {_parts["doors"]}";
        }
    }
}