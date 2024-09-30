using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopBuilder
{
    public class BusinessLaptopBuilder : ILaptopBuilder
    {
        private Laptop laptop = new Laptop();

        public void SetProcessor()
        {
            laptop.Processor = "Intel i5";
        }

        public void SetRAM()
        {
            laptop.RAM = "16GB";
        }

        public void SetGraphicsCard()
        {
            laptop.GraphicsCard = "Integrated Graphics";
        }

        public void SetStorage()
        {
            laptop.Storage = "512GB SSD";
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }

}
