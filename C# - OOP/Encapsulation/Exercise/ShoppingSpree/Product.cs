using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }

        public double Cost { get; set; }
    }
}
