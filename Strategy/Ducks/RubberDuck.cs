using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    class RubberDuck: Duck
    {
        public override void display()
        {
            Console.WriteLine("Rubber Duck showing");
        }
    }
}
