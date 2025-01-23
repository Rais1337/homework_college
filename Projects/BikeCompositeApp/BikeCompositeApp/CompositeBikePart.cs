using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeCompositeApp
{
    public class CompositeBikePart : IBikeComponent
    {
        public string Name { get; }
        private List<IBikeComponent> _components = new List<IBikeComponent>();

        public CompositeBikePart(string name)
        {
            Name = name;
        }

        public void Add(IBikeComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IBikeComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + Name);
            foreach (var component in _components)
            {
                component.Display(indent + 2);
            }
        }

        public string GetStructure(int indent)
        {
            string result = new string('-', indent) + Name + "\n";
            foreach (var component in _components)
            {
                result += component.GetStructure(indent + 2);
            }
            return result;
        }
    }

}
