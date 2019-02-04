using PizzaStore.Factory;
using PizzaStore.Pizza;
using PizzaStore.Pizza.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory pf)
        {
            factory = pf;
        }

        public PizzaBase OrderPizza(string type)
        {
            PizzaBase pizza = factory.CreatePizza(type);

            pizza.Display();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;


        }




    }
}
