using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizza.Factory
{
    class PizzaFactory
    {
        public Pizza GetPizza(PizzaType pizzaType) =>
            pizzaType switch
            {
                PizzaType.Salame => new SalamePizza(),
                PizzaType.Mozzarella => new MozzarellaPizza(),
                PizzaType.Vegi => new VegiPizza(),
                _ => null,
            };
    }
}
