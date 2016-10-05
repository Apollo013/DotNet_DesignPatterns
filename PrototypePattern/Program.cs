using PrototypePattern.Abstract;
using PrototypePattern.Concrete;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalPrototype Sheep = new Sheep("Dolly");
            Sheep Dolly = Sheep.Clone() as Sheep;
            Dolly.MakeSound();
        }
    }
}
