using FactoryMethod.Animals;
using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class WaterAnimFactory : IFactory
    {
        IAnimal animal = null;

        public WaterAnimFactory()
        {

        }

        public IAnimal FactoryMethod(AnimalSpecies animalSpecies)
        {
            switch (animalSpecies)
            {
                case AnimalSpecies.Salmon:
                    animal = new Salmon();
                    break;
                case AnimalSpecies.Tuna:
                    animal = new Tuna();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong AnimalSpecies");
                    break;
            }

            return animal;
        }
    }
}
