using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightGarland
{
    public class GarlandDisplay : Panel
    {
        private List<(ILight light, int x, int y)> lights = new();

        public void AddLight(ILight light, int x, int y)
        {
            lights.Add((light, x, y));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var (light, x, y) in lights)
            {
                light.Draw(e.Graphics, x, y);
            }
        }
    }

}
