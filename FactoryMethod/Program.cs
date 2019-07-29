using FactoryMethod.Factories;
using FactoryMethod.Animals;
using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory LandFactory = new LandAnimFactory();

            LandFactory.FactoryMethod(AnimalSpecies.Cat);
            LandFactory.FactoryMethod(AnimalSpecies.Salmon);

            IFactory WaterFactory = new WaterAnimFactory();
            WaterFactory.FactoryMethod(AnimalSpecies.Salmon);
            WaterFactory.FactoryMethod(AnimalSpecies.Dog);

            Console.ReadKey();
        }
    }
}
