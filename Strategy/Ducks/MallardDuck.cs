using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // usa implementaciones concretas. el libro dice que si... por ahora.
            quackBehavior = new Behaviors.Quack();
            flyBehavior = new Behaviors.FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("Mallard Duck showing");
        }
    }
}
