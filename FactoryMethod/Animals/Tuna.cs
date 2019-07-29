using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animals
{
    class Tuna : IAnimal
    {
        public Tuna()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You made a Tuna");
        }
    }
}
