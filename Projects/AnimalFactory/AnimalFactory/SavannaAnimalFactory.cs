using AnimalFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    public class SavannaAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Zebra();
        }

        public IAnimal CreateBird()
        {
            return new Flamingo();
        }

        public IAnimal CreateReptile()
        {
            return new Gecko();
        }
    }

}
