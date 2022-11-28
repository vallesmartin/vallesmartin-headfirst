using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("No flying");
        }
    }
}
