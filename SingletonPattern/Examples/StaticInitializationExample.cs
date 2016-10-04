namespace SingletonPattern
{
    public sealed class StaticInitializationExample
    {
        private static readonly StaticInitializationExample instance = new StaticInitializationExample();

        private StaticInitializationExample() { }

        public static StaticInitializationExample Instance
        {
            get
            {
                return instance;
            }
        }

        public void Print()
        {
            System.Console.WriteLine("StaticInitializationExample");
        }

    }
}
