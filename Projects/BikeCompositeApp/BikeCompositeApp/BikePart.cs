using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeCompositeApp
{
    public class BikePart : IBikeComponent
    {
        public string Name { get; }

        public BikePart(string name)
        {
            Name = name;
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + Name);
        }

        public string GetStructure(int indent)
        {
            return new string('-', indent) + Name + "\n";
        }
    }

}
