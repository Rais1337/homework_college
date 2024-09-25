using AnimalFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    public class JungleAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateMammal()
        {
            return new Tiger();
        }

        public IAnimal CreateBird()
        {
            return new Parrot();
        }

        public IAnimal CreateReptile()
        {
            return new Python();
        }
    }

}
