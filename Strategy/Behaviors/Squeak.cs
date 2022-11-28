using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("SQUEAAAAAK");
        }
    }
}
