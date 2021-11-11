using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizza
{
    class MozzarellaPizza : Pizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> Toppings { get; set; }

        public MozzarellaPizza()
        {
            this.Name = "Mozzarella Pizza";
            this.Price = 6.50;
            this.Toppings = new List<string>();
        }
    }
}
