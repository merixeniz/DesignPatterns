using FactoryMethod.Animals;
using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class LandAnimFactory : IFactory
    {
        IAnimal animal = null;

        public LandAnimFactory()
        {
            //to do zrobienie roznej fabryki
        }

        public IAnimal FactoryMethod(AnimalSpecies animalSpecies)
        {
            switch (animalSpecies)
            {
                case AnimalSpecies.Cat:
                    animal = new Cat();
                    break;
                case AnimalSpecies.Dog:
                    animal = new Dog();
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
