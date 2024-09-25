using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animals
{
    public class Zebra : IAnimal
    {
        public string Speak()
        {
            return "Зебра: *еще какой-то звук*";
        }
    }

}
