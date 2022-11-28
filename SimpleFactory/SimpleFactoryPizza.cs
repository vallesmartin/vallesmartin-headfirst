using System;

namespace SimpleFactory
{
    abstract class SimpleFactoryPizza
    {
        public static Pizza createPizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    return new CheesePizza();
                case "Margarita":
                    return new MargaritaPizza();
                default:
                    throw new InvalidPizzaTypeException("El Tipo de pizza: '" + type + "' no es correcto");
            }
        }

        [Serializable]
        public class InvalidPizzaTypeException : Exception
        {
            public InvalidPizzaTypeException() { }
            public InvalidPizzaTypeException(string message) : base(message) { }
            public InvalidPizzaTypeException(string message, Exception inner) : base(message, inner) { }
            protected InvalidPizzaTypeException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}
