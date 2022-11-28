using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Vuela con Alas");
        }
    }
}
