using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    public interface IAnimalFactory
    {
        IAnimal CreateMammal();
        IAnimal CreateBird();
        IAnimal CreateReptile();
    }

}
