using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class Mute : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("...");
        }
    }
}
