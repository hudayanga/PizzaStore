using PizzaStore.Pizza.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaStore.Pizza
{
    public class OnionPizza : PizzaBase
    {
        public override void Display()
        {
            Console.WriteLine("Start your Onion Pizza");
            Thread.Sleep(2000);
        }
    }
}
