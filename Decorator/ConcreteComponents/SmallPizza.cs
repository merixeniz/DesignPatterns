using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 12.50f;
        }

        public override string GetName()
        {
            return "Small Pizza";
        }
    }
}
