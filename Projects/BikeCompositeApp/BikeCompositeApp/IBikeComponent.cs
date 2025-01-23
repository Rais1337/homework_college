using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeCompositeApp
{
    public interface IBikeComponent
    {
        string Name { get; }
        void Display(int indent);
        string GetStructure(int indent);
    }


}
