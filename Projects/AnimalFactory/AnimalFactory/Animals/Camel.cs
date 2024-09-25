using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animals
{
    public class Camel : IAnimal
    {
        public string Speak()
        {
            return "Верблюд: Хрюк!";
        }
    }

}
