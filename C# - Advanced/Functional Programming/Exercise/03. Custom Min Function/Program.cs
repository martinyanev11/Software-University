using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get int array from console
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Create function that takes an array and returns int
            // Lambda function determines how it operates

            //Fun<inT, outT>   name   =  method of operation == minNumber = numbers.Min();
            Func<int[], int> findMinNumber = x => x.Min();

            //Store the returned result from the Func into variable by applying the Func on the array
            int minNumber = findMinNumber(numbers);
            Console.WriteLine(minNumber);
        }
    }
}
