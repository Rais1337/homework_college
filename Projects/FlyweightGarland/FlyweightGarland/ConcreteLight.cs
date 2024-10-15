using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGarland
{
    public class ConcreteLight : ILight
    {
        private Color color;

        public ConcreteLight(Color color)
        {
            this.color = color;
        }

        public void Draw(Graphics g, int x, int y)
        {
            using (Brush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, y, 20, 20);
            }
        }
    }

}
