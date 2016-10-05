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
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(divider);

            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
