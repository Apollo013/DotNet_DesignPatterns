using System;
using System.Collections.Generic;

namespace BuilderPattern.Entities
{
    /// <summary>
    /// Class that contains all the parts used to build the product
    /// </summary>
    public class Vehicle
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

        public void Show()
        {
            string divider = new string('-', 60);
            Console.WriteLine(divider);
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine(divider);

            foreach (KeyValuePair<string, string> part in _parts)
            {
                Console.WriteLine($"{part.Key}:\t{part.Value}");
            }
            Console.WriteLine();
        }
    }
}
