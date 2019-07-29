using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animals
{
    class Dog : IAnimal
    {
        public Dog()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You made a dog");
        }
    }
}
