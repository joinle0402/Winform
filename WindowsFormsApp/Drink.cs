using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Drink
    {
        public Drink(string drinkName, double unitPrice)
        {
            DrinkName = drinkName;
            UnitPrice = unitPrice;
        }

        public Drink() {}

        public string DrinkName { get; set; }
        public double UnitPrice { get; set; }
    }
}
