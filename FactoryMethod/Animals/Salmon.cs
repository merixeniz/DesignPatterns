using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animals
{
    class Salmon : IAnimal
    {
        public Salmon()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You made a Salmon");
        }
    }
}
