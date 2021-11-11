using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizza
{
    class SalamePizza : Pizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> Toppings { get; set; }

        public SalamePizza()
        {
            Name = "Salame Pizza";
            Price = 7.5;
            Toppings = new List<string>();
        }
    }
}
