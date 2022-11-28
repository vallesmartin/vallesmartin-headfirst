namespace vallesmartin.HeadFirst.Factory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza createPizza(string type);
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.Bake();
            pizza.Box();
            return pizza;
        }
    }

    public class VinnieStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("Cheese"))
            {
                return new CheesePizza();
            }
            else if (item.Equals("Margarita"))
            {
                return new MargaritaPizza();
            }
            else return null;
        }
    }

    public class AntoniasStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("AntoniasSpeciale"))
            {
                return new AntoniasSpecialePizza();
            }
            else if (item.Equals("Margarita"))
            {
                return new MargaritaPizza();
            }
            else return null;
        }
    }
}
