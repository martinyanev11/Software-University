using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private const int moneyMinValue = 0;

        private string name;
        private int money;
        private List<Product> products;

        private Person()
        {
            products = new List<Product>();
        }

        public Person(string name, int money)
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
                    throw new Exception("The name cannot be an empty string.");
                }
                name = value;
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value > moneyMinValue)
                {
                    throw new Exception("Money cannot be a negative number.");
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

        public void BuyProduct(Person person, Product product)
        {

        }
    }
}
