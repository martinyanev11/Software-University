using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private const int moneyMinValue = 0;

        private string name;
        private double money;
        private readonly List<Product> products;

        private Person()
        {
            products = new List<Product>();
        }

        public Person(string name, double money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value; 
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < moneyMinValue)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.products.Add(product);
                return $"{this.Name} bought {product.Name}";
            }
            return $"{this.Name} can't afford {product.Name}";
        }

        public override string ToString()
        {
            if (this.products.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                List<string> boughtProducts = new List<string>();

                foreach (var product in products)
                {
                    boughtProducts.Add(product.Name);
                }

                sb.Append($"{this.Name} - {string.Join(", ", boughtProducts)}");
                return sb.ToString();
            }

            return $"{this.Name} - Nothing bought";
        }
    }
}
