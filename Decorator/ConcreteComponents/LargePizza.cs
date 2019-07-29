using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public override double CalculateCost()
        {
            return 50.00f;
        }

        public override string GetName()
        {
            return "Large Pizza";
        }
    }
}
