namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicExample.Instance.Print();
            StaticInitializationExample.Instance.Print();
            ThreadSafeNestedExample.Instance.Print();
            ThreadSafeDoubleCheckExample.Instance.Print();
        }
    }
}
