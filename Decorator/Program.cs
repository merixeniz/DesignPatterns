using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();

            largePizza = new CheeseDecorator(largePizza);
            largePizza = new HamDecorator(largePizza);

            Console.WriteLine("Pizza name: {0}, Pizza price: {1}", largePizza.GetName(), largePizza.CalculateCost());
            Console.ReadLine();
        }
    }
}
