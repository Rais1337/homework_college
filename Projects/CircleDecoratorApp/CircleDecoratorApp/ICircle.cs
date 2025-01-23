using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDecoratorApp
{
    public interface ICircle
    {
        void Draw();
        double Radius { get; set; }
    }

}
