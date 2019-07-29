using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            Console.WriteLine("You made a dog");
        }
    }
}
