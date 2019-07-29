using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Salmon : IAnimal
    {
        public Salmon()
        {
            Console.WriteLine("You made a Salmon");
        }
    }
}
