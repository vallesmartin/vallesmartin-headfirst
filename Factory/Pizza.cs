using System;

namespace vallesmartin.HeadFirst.Factory
{
    public abstract class Pizza
    {
        public abstract void Bake();
        public abstract void Box();
    }

    public class CheesePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking Cheese Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing Cheese Pizza");
        }
    }

    public class MargaritaPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking Margarita Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing Margarita Pizza");
        }
    }

    public class AntoniasSpecialePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking AntoniasSpeciale Pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing AntoniasSpeciale Pizza");
        }
    }
}
