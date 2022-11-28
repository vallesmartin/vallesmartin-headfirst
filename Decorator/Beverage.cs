using System;

namespace vallesmartin.HeadFirst.Decorator
{
    public abstract class Beverage
    {
        public string description;

        public virtual string getDescrption()
        {
            return description;
        }

        public virtual float cost()
        {
            throw new NotImplementedException();
        }
    }
}
