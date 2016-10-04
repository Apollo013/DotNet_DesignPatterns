using FactoryPattern.Entities.Abstract;
using FactoryPattern.Entities.Concrete;
using FactoryPattern.Factories.Abstract;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern.Factories.Concrete
{
    public class ReflectionVehicleFactory : IReflectionVehicleFactory
    {
        Dictionary<string, Type> vehicles;

        public ReflectionVehicleFactory()
        {
            LoadTypes();
        }
        public IVehicle Create(string type)
        {
            Type t = GetType(type);

            // Return a 'Null Object' substitute
            if (t == null)
            {
                return new UnknownVehicle();
            }
            // Create a new instance and return it
            return Activator.CreateInstance(t) as IVehicle;
        }

        /// <summary>
        /// Gets the type of vehicle based on a string comparison
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Type GetType(string type)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Key.Contains(type))
                {
                    return vehicles[vehicle.Key];
                }
            }
            return null;
        }

        /// <summary>
        /// Get a list of all classes derived from the 'IVehicle' interface
        /// </summary>
        private void LoadTypes()
        {
            vehicles = new Dictionary<string, Type>();

            // Get a list of all types in this assembly
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.GetInterface(typeof(IVehicle).ToString()) != null)
                {
                    vehicles.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
