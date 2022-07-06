using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            List<Product> productsList = new List<Product>();

            // First console line is people input:
            string[] peopleInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleInput.Length - 1; i += 2)
            {
                string name = peopleInput[i];
                int money = int.Parse(peopleInput[i + 1]);

                Person person = new Person(name, money);
                peopleList.Add(person);
            }

            // Second console line is products input:
            string[] productInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productInput.Length - 1; i += 2)
            {
                string name = productInput[i];
                int cost = int.Parse(productInput[i + 1]);

                Product product = new Product(name, cost);
                productsList.Add(product);
            }
        }
    }
}
