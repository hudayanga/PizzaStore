using PizzaStore.Pizza;
using PizzaStore.Pizza.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Factory
{
    public class SimplePizzaFactory
    {
        public PizzaBase CreatePizza( string type)
        {
            PizzaBase pizza = null;

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("Onion"))
            {
                pizza = new OnionPizza();
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }
    }
}
