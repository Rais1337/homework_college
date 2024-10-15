using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopBuilderPrototype
{
    public interface ILaptopBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetGraphicsCard();
        void SetStorage();
        Laptop GetLaptop();
        Laptop CloneLaptop();
    }

}
