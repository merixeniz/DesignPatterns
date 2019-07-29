using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IFactory
    {
        IAnimal FactoryMethod(AnimalSpecies animalSpecies);
    }
}
