using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    class RedHeadDuck: Duck
    {
        public override void display()
        {
            Console.WriteLine("RedHead Duck showing");
        }

        public void fly()
        {
            Console.WriteLine("RedHead Duck FLYING");
        }

        public void quack()
        {
            Console.WriteLine("RedHead Duck QUAKING");
        }
    }
}
