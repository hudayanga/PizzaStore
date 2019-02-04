using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaStore.Pizza.Base
{
    public abstract class PizzaBase
    {
        public abstract void Display();
     

        public void Prepare()
        {
            Console.WriteLine("Preparing Pizza");
            Thread.Sleep(2000);

        }

        public void Bake()
        {
            Console.WriteLine("Baking Pizza");
            Thread.Sleep(2000);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pizza");
            Thread.Sleep(2000);
        }

        public void Box()
        {
            Console.WriteLine("Packing your Pizza");
            Thread.Sleep(2000);
        }
    }
}
