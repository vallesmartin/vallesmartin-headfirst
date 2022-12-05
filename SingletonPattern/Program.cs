using System;

namespace SingletonPattern
{
    //The Singleton Pattern ensures a class has only one
    //instance, and provides a global point of access to it.
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler choc = ChocolateBoiler.GetInstance;
            ChocolateBoiler choc2 = ChocolateBoiler.GetInstance;
            ChocolateBoiler choc3 = ChocolateBoiler.GetInstance;

            if (choc == choc2 && choc2 == choc3)
                Console.WriteLine("Same instance");
            else
                Console.WriteLine("Different instance (it should never execute this line)");

            choc.Fill();
            choc2.Boil();
            choc3.PourWhenBoiled();

            Console.ReadLine();
        }
    }
    public sealed class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler instance = null;
        private static readonly object _lock = new object();
        ChocolateBoiler() {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                    return instance;
                }
            }
        }
        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Filled");
            }else Console.WriteLine("Already filled !");
        }
        public void Boil()
        {
            if (!boiled)
            {
                boiled = true;
                Console.WriteLine("Boiled");
            }
            else Console.WriteLine("Already boiled !");
        }
        public void PourWhenBoiled()
        {
            if(!empty && boiled)
            {
                empty = true;
                boiled = false;
                Console.WriteLine("Empty");
            }
            else Console.WriteLine("Already empty !");
        }
        // rest of ChocolateBoiler code...
    }
}
