using System;

namespace vallesmartin.HeadFirst.Factory
{
    class Program
    {
        //The Factory Method Pattern defines an interface
        //for creating an object, but lets subclasses decide which
        //class to instantiate.Factory Method lets a class defer
        //instantiation to subclasses.
        static void Main(string[] args)
        {
            PizzaStore Antonias = new AntoniasStore();
            PizzaStore Vinnie= new VinnieStore();

            Antonias.orderPizza("Margarita");
            Console.WriteLine("");
            Antonias.orderPizza("AntoniasSpeciale");
            Console.WriteLine("");

            Vinnie.orderPizza("Cheese");
            Console.WriteLine("");
            Vinnie.orderPizza("Margarita");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
