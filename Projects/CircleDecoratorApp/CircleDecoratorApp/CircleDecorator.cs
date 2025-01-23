using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDecoratorApp
{
    public abstract class CircleDecorator : ICircle
    {
        protected ICircle _circle;

        public CircleDecorator(ICircle circle)
        {
            _circle = circle;
        }

        public virtual void Draw()
        {
            _circle.Draw();
        }

        public double Radius
        {
            get => _circle.Radius;
            set => _circle.Radius = value;
        }
    }

}
