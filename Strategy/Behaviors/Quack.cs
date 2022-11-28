using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("QUAAAACK");
        }
    }
}
