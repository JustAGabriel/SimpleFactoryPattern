using SimpleFactoryPattern.Pizza;
using SimpleFactoryPattern.Pizza.Factory;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory pizzaFactory = new PizzaFactory();

            Pizza.Pizza salamePizza = pizzaFactory.GetPizza(PizzaType.Salame);
            Trace.WriteLine(salamePizza.ToString());

            Pizza.Pizza mozzarellaPizza = pizzaFactory.GetPizza(PizzaType.Mozzarella);
            Trace.WriteLine(mozzarellaPizza.ToString());

            Pizza.Pizza vegiPizza = pizzaFactory.GetPizza(PizzaType.Vegi);
            Trace.WriteLine(vegiPizza.ToString());

            Task.Delay(5000);

            Trace.WriteLine("Done.");
        }
    }
}
