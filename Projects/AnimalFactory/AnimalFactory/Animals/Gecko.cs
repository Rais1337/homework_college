using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animals
{
    public class Gecko : IAnimal
    {
        public string Speak()
        {
            return "Гекон: клац-клац!";
        }
    }

}
