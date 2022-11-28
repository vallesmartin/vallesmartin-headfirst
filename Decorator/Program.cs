using System;

namespace vallesmartin.HeadFirst.Decorator
{
    class Program
    {
        /*
            The Decorator Pattern attaches additional 
            responsibilities to an object dynamically. 
            Decorators provide a flexible alternative to 
            subclassing for extending functionality.
        */
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.getDescrption() + " $" + espresso.cost());

            Beverage espresso2 = new Espresso();
            espresso2 = new Milk(espresso2);
            Console.WriteLine(espresso2.getDescrption() + " $" + espresso2.cost());

            Beverage espresso3 = new Espresso();
            espresso3 = new Milk(espresso3);
            espresso3 = new Whip(espresso3);
            Console.WriteLine(espresso3.getDescrption() + " $" + espresso3.cost());

            Console.ReadLine();
        }
    }
}
