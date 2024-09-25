using AnimalFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    public class DesertAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Camel();
        }

        public IAnimal CreateBird()
        {
            return new Falcon();
        }

        public IAnimal CreateReptile()
        {
            return new Lizard();
        }
    }

}
