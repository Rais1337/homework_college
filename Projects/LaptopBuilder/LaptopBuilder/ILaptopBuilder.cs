using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopBuilder
{
    public interface ILaptopBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetGraphicsCard();
        void SetStorage();
        Laptop GetLaptop();
    }

}
