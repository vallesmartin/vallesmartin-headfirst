using System;
using vallesmartin.HeadFirst.Strategy.Behaviors;
using vallesmartin.HeadFirst.Strategy.Ducks;

namespace vallesmartin.HeadFirst.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  The Strategy Pattern defines a family of algorithms (implementations of fly and quack behaviors), 
                encapsulates each one (each implementation), and makes them interchangeable (through interface). 
                Strategy lets the algorithm vary independently from 
                clients that use it (setFlyBehavior).
             */
            Duck mallard = new MallardDuck();
            Duck rubber = new RubberDuck();
            Duck redhead = new RedHeadDuck();
            Duck model = new ModelDuck();

            mallard.display();
            mallard.performQuack();
            mallard.performFly();

            rubber.display();

            redhead.display();

            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();

            Console.ReadKey();
        }
    }
}
