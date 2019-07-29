using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponents
{
    public class MediumPizza : Pizza
    {
        public override double CalculateCost()
        {
            return 30.00f;
        }

        public override string GetName()
        {
            return "Medium Pizza";
        }
    }
}
