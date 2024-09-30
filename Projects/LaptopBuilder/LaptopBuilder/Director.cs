using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopBuilder
{
    public class Director
    {
        private ILaptopBuilder builder;

        public Director(ILaptopBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildLaptop()
        {
            builder.SetProcessor();
            builder.SetRAM();
            builder.SetGraphicsCard();
            builder.SetStorage();
        }
    }

}
