using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Dinosaur : IAnimal
    {
        public Dinosaur()
        {
            Console.WriteLine("You made a Dino");
        }
    }
}
