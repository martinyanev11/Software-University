using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersNumber = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int i = 0; i < ordersNumber; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double orderSum = ((days * capsuleCount) * capsulePrice);
                totalSum += orderSum;

                Console.WriteLine($"The price for the coffee is: ${orderSum:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
