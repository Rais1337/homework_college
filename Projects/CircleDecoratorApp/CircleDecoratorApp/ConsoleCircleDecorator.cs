using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDecoratorApp
{
    public class ConsoleCircleDecorator : CircleDecorator
    {
        public ConsoleCircleDecorator(ICircle circle) : base(circle) { }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Additional console output for the circle.");
        }
    }

}
