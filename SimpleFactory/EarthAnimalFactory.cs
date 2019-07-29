using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class EarthAnimalFactory
    {
        IAnimal animal = null;

        public IAnimal createAnimal(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    animal = new Cat();
                    break;
                case AnimalType.Dog:
                    animal = new Dog();
                    break;
                case AnimalType.Dino:
                    animal = new Dinosaur();
                    break;
                default:
                    Console.WriteLine("Woring species");
                    break;
            }
            
            return animal;

        }

        
    }
}
