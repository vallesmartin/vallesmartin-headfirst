using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    class DecoyDuck: Duck
    {
        public void quack()
        {
            Console.WriteLine("-no sound-");
        }
        public override void display()
        {
            Console.WriteLine("Rubber Duck showing");
        }
    }
}
