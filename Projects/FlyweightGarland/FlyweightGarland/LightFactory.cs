using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGarland
{
    public class LightFactory
    {
        private Dictionary<Color, ILight> lights = new();

        public ILight GetLight(Color color)
        {
            if (!lights.ContainsKey(color))
            {
                lights[color] = new ConcreteLight(color);
            }
            return lights[color];
        }
    }

}
