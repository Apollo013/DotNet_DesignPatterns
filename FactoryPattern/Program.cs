using FactoryPattern.Entities.Abstract;
using FactoryPattern.Factories.Abstract;
using FactoryPattern.Factories.Concrete;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSimpleFactoryExample();
            AbstractFactoryExample();
            ReflectionFactoryExample();
        }

        /// <summary>
        /// Demonstrates a very basic implementation
        /// </summary>
        private static void RunSimpleFactoryExample()
        {
            Print("Simple Factory Example");
            IVehicle vehicle = SimpleVehicleFactory.Create("Car");
            vehicle.SwithchOn();
            vehicle.SwitchOff();

            System.Console.WriteLine();

            // Demonstration of 'Null Object' pattern
            IVehicle unknownVehicle = SimpleVehicleFactory.Create("");
            unknownVehicle.SwithchOn();
            unknownVehicle.SwitchOff();
        }

        /// <summary>
        /// Demonstrates abstract/concrete method
        /// </summary>
        private static void AbstractFactoryExample()
        {
            Print("Abstract Factory Example");
            string divider = new string('-', 50);

            AbstractVehicleFactory[] factories = new AbstractVehicleFactory[3];
            factories[0] = new HangerFactory();
            factories[1] = new HarbourFactory();
            factories[2] = new ShowroomFactory();

            // Iterate through each factory
            foreach (var factory in factories)
            {
                System.Console.WriteLine(divider);
                System.Console.WriteLine(factory.GetType().Name);
                System.Console.WriteLine(divider);
                // Iterate through each vehicle in the factory
                foreach (var vehicle in factory.Vehicles)
                {
                    System.Console.WriteLine($"\t{vehicle.GetType().Name}");
                }
                System.Console.WriteLine();
            }
        }

        /// <summary>
        /// Demonstrates an abstract/concrete implementation using reflection
        /// </summary>
        private static void ReflectionFactoryExample()
        {
            Print("Reflection Factory Example");
            string divider = new string('-', 50);

            IReflectionVehicleFactory factory = new ReflectionVehicleFactory();
            var vehicle = factory.Create("sailingship");
            vehicle.SwithchOn();
            vehicle.SwitchOff();

            System.Console.WriteLine();

            var vehicle2 = factory.Create("passengerplane");
            vehicle2.SwithchOn();
            vehicle2.SwitchOff();
        }

        private static void Print(string title)
        {
            string divider = new string('-', 100);

            System.Console.WriteLine();
            System.Console.WriteLine(divider);
            System.Console.WriteLine(title);
            System.Console.WriteLine(divider);
        }
    }
}
