using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animals
{
    public class Lizard : IAnimal
    {
        public string Speak()
        {
            return "Ящірка: Скррр!";
        }
    }

}
