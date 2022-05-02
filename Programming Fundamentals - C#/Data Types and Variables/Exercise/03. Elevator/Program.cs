using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleNumber = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(peopleNumber / capacity);
            Console.WriteLine(courses);
        }
    }
}
