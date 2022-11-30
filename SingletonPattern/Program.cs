namespace SingletonPattern
{
    //The Singleton Pattern ensures a class has only one
    //instance, and provides a global point of access to it.
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public sealed class Singleton
    {
        Singleton() { }
        private static readonly object _lock = new object();  
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
