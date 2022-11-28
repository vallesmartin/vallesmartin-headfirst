using vallesmartin.HeadFirst.Strategy.Behaviors;
using System;

namespace vallesmartin.HeadFirst.Strategy.Ducks
{
    abstract class Duck
    {
        // void fly()
        // void quack()
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        
        public void performFly() 
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public void swim()
        {
            Console.WriteLine("SWIM");
        }
        public virtual void display() 
        {
            Console.WriteLine("A shade shaped like a duck appears");
        }
    }
}
