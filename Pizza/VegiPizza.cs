using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizza
{
    class VegiPizza : Pizza 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> Toppings { get; set; }

        public VegiPizza()
        {
            this.Name = "Vegi Pizza";
            this.Price = 5.50;
            this.Toppings = new List<string>();
        }
    }
}
