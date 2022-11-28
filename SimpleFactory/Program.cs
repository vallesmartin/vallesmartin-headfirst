using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza cheese = SimpleFactoryPizza.createPizza("Cheese");
            Pizza margarita = SimpleFactoryPizza.createPizza("Margarita");
            try
            {
                Pizza chorizo = SimpleFactoryPizza.createPizza("Chorizo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            cheese.Bake();
            margarita.Bake();

            cheese.Box();
            margarita.Box();

            Console.ReadKey();
        }
    }
}
