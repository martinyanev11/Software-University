using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> players = new Queue<string>(input);

            // n - determines the hot potatoes passes before leaving someone the game
            int n = int.Parse(Console.ReadLine());

            // Game starts
            string playerToRotate = string.Empty;

            while (players.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    playerToRotate = players.Dequeue();
                    players.Enqueue(playerToRotate);
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
