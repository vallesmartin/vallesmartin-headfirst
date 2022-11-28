using vallesmartin.HeadFirst.Strategy.Behaviors;
using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Model duck showing");
        }
    }
}
