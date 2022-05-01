using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int townPop = int.Parse(Console.ReadLine());
            short squrKm = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {townPop} and area {squrKm} square km.");
        }
    }
}
