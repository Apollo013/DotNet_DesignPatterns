namespace SingletonPattern
{
    /*
     This double-check locking approach solves the thread concurrency problems while 
     avoiding an exclusive lock in every call to the Instance property method. 
     It also allows you to delay instantiation until the object is first accessed
     */

    public class ThreadSafeDoubleCheckExample
    {
        // volatile => ensures that assignment to the instance variable completes before the instance variable can be accessed.
        // object => prevents deadlock

        private static object sync = new object();
        private static volatile ThreadSafeDoubleCheckExample instance;

        private ThreadSafeDoubleCheckExample() { }

        public static ThreadSafeDoubleCheckExample Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeDoubleCheckExample();
                        }
                    }
                }

                return instance;
            }
        }

        public void Print()
        {
            System.Console.WriteLine("ThreadSafeDoubleCheckExample");
        }

    }
}
