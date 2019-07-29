using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            EarthAnimalFactory animFactory = new EarthAnimalFactory();

            animFactory.createAnimal(AnimalType.Dog);

            Console.ReadKey();
        }
    }
}
