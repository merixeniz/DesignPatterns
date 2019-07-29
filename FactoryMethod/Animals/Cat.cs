using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animals
{
    public class Cat : IAnimal
    {
        public Cat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You made a cat");
        }
    }
}
