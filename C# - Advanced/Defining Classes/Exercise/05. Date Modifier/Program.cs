using System;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            string d1 = Console.ReadLine();
            string d2 = Console.ReadLine();

            DateModifier date = new DateModifier();
            int result = date.DaysDifference(d1, d2);
            Console.WriteLine(result);
        }
    }
}
