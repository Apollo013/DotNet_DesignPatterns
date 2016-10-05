using PrototypePattern.Abstract;

namespace PrototypePattern.Concrete
{
    public class Sheep : AnimalPrototype
    {
        private string _name;

        public Sheep(string name)
        {
            _name = name;
        }

        public override AnimalPrototype Clone()
        {
            System.Console.WriteLine($"{_name} says 'I've just been cloned, this is Baaaaaaaaaaaaaaaad'");
            return this.MemberwiseClone() as AnimalPrototype;
        }

        public void MakeSound()
        {
            System.Console.WriteLine("Baa");
        }
    }
}
