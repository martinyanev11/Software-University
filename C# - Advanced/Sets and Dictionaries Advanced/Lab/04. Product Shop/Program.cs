using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopsDictionary = new SortedDictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                // Read input
                string[] cmdArgs = input.Split(", ");
                string shopName = cmdArgs[0];
                string productName = cmdArgs[1];
                double productPrice = double.Parse(cmdArgs[2]);

                // Add shop to the dictionary if it doesn't exist
                if (!shopsDictionary.ContainsKey(shopName))
                {
                    shopsDictionary.Add(shopName, new Dictionary<string, double>());
                }

                // Add product to shop if it doesn't exist
                if (!shopsDictionary[shopName].ContainsKey(productName))
                {
                    shopsDictionary[shopName].Add(productName, productPrice);
                }

            }
            // Print the result (revision)
            foreach (var shop in shopsDictionary)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
