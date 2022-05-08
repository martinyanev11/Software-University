using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
            {
                if (playerOneDeck[0] > playerTwoDeck[0])
                {
                    playerOneDeck.Add(playerTwoDeck[0]);
                    playerOneDeck.Add(playerOneDeck[0]);
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }
                else if (playerOneDeck[0] < playerTwoDeck[0])
                {
                    playerTwoDeck.Add(playerOneDeck[0]);
                    playerTwoDeck.Add(playerTwoDeck[0]);
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }
                else
                {
                    playerOneDeck.RemoveAt(0);
                    playerTwoDeck.RemoveAt(0);
                }
            }
            int winningDeckSum = Math.Max(playerOneDeck.Sum(), playerTwoDeck.Sum());
            if (playerOneDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {winningDeckSum}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {winningDeckSum}");
            }
        }
    }
}
