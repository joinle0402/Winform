using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Vehicle
    {
        public Vehicle(string manufacturer, int yearOfProduction, int engine, double price)
        {
            this.Manufacturer = manufacturer;
            this.YearOfProduction = yearOfProduction;
            this.Engine = engine;
            this.Price = price;
        }

        public Vehicle() {}

        public string Manufacturer { get; set; }
        public int YearOfProduction { get; set; }
        public int Engine { get; set; }
        public double Price { get; set; }
    }
}
