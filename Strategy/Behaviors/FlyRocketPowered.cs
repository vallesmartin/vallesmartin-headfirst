using System;

namespace vallesmartin.HeadFirst.Strategy.Behaviors
{
    class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Flying like a Rocket !!");
        }
    }
}
