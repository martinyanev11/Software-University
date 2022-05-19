using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songsQueue = new Queue<string>(songsArr);

            while (songsQueue.Count > 0)
            {
                string commandType = Console.ReadLine();

                if (commandType == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (commandType == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                else
                {
                    string songToAdd = commandType.Substring(4);
                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songToAdd);
                    }
                }
                
            }

            Console.WriteLine("No more songs!");
        }
    }
}
