using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public abstract class Pizza
    {
        public abstract double CalculateCost();
        public abstract string GetName();
    }
}
