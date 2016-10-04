namespace SingletonPattern
{
    public class ThreadSafeNestedExample
    {
        private ThreadSafeNestedExample() { }

        public static ThreadSafeNestedExample Instance
        {
            get { return Singleton.instance; }
        }

        private class Singleton
        {
            static Singleton() { }
            internal static readonly ThreadSafeNestedExample instance = new ThreadSafeNestedExample();
        }

        public void Print()
        {
            System.Console.WriteLine("ThreadSafeNestedExample");
        }

    }
}
