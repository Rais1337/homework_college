using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDecoratorApp
{
    using System.Drawing;
    using System.Windows.Forms;

    public class WinFormsCircleDecorator : CircleDecorator
    {
        private Form _form;

        public WinFormsCircleDecorator(ICircle circle, Form form) : base(circle)
        {
            _form = form;
        }

        public override void Draw()
        {
            base.Draw();

            _form.Paint += (sender, e) =>
            {
                Graphics graphics = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                float diameter = (float)(Radius * 2);
                float x = (_form.ClientSize.Width - diameter) / 2;
                float y = (_form.ClientSize.Height - diameter) / 2;
                graphics.DrawEllipse(pen, x, y, diameter, diameter);
            };

            _form.Invalidate();
        }
    }

}
