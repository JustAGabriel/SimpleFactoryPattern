using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Pizza
{
    abstract class Pizza
    {
        string Name { get; set; }
        double Price { get; set; }
        List<string> Toppings { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var prop in this.GetType().GetProperties())
            {
                stringBuilder.Append(prop.Name + ": " + prop.GetValue(this));
            }

            return stringBuilder.ToString();
        }
    }
}
