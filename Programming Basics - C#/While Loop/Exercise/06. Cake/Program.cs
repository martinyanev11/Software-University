using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle cake size
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakeSize = length * width;

            string input;
            while ((input = Console.ReadLine()) != "STOP")
            {
                int cakePiecesTaken = int.Parse(input);
                cakeSize -= cakePiecesTaken;

                if (cakeSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }
            }

            if (cakeSize >= 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
