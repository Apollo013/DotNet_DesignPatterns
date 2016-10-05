namespace SingletonPattern
{
    /*
     The instantiation is not performed until an object asks for an instance; this approach is referred to as lazy instantiation. 
     Lazy instantiation avoids instantiating unnecessary singletons when the application starts.

     Not safe for multithreaded environments. This means that multiple instances could be created.
     */
    public class BasicExample
    {
        private static BasicExample instance;

        private BasicExample()
        {
            // Perform any other initializations here
        }

        public static BasicExample Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BasicExample();
                }
                return instance;
            }
        }

        public void Print()
        {
            System.Console.WriteLine("BasicExample");
        }
    }
}
