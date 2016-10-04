using FactoryPattern.Entities.Abstract;
using System.Collections.Generic;

namespace FactoryPattern.Factories.Abstract
{
    public abstract class AbstractVehicleFactory
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        public List<IVehicle> Vehicles
        {
            get
            {
                return vehicles;
            }
        }

        public AbstractVehicleFactory()
        {
            Fill();
        }

        public abstract void Fill();
    }
}
