using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopBuilder
{
    public class GamingLaptopBuilder : ILaptopBuilder
    {
        private Laptop laptop = new Laptop();

        public void SetProcessor()
        {
            laptop.Processor = "Intel i9";
        }

        public void SetRAM()
        {
            laptop.RAM = "32GB";
        }

        public void SetGraphicsCard()
        {
            laptop.GraphicsCard = "NVIDIA RTX 3080";
        }

        public void SetStorage()
        {
            laptop.Storage = "1TB SSD";
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }

}
