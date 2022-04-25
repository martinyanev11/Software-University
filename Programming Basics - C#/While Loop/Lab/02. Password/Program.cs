using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            string pwCheck = Console.ReadLine();

            while (password != pwCheck)
            {
                pwCheck = Console.ReadLine();
            }

            Console.WriteLine("Welcome " + userName + "!");
        }
    }
}
