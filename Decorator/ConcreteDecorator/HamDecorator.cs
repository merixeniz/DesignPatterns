using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza) : base (pizza)
        {

        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.00f;
        }

        public override string GetName()
        {
            return base.GetName() + " Ham";
        }
    }
}
