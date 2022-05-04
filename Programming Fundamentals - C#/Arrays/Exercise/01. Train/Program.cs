using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] people = new int[n];
            int sumOfPeople = 0;

            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sumOfPeople += people[i];
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sumOfPeople);

        }
    }
}
