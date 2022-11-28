namespace vallesmartin.HeadFirst.Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }
        public override float cost()
        {
            return 3.99f;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override float cost()
        {
            return 1.99f;
        }
    }

    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public override abstract string getDescrption();
    }

    public class Milk: CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescrption()
        {
            return beverage.getDescrption() + ", Milk";
        }

        public override float cost()
        {
            return beverage.cost() + .33f;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescrption()
        {
            return beverage.getDescrption() + ", Whip";
        }

        public override float cost()
        {
            return beverage.cost() + .33f;
        }
    }
}
