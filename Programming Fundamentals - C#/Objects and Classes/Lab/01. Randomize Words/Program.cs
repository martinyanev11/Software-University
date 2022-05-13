using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Random randomNumber = new Random();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                int randomIndex = randomNumber.Next(0, wordsArray.Length);

                string currentWord = wordsArray[i];
                wordsArray[i] = wordsArray[randomIndex];
                wordsArray[randomIndex] = currentWord;
            }

            foreach (var word in wordsArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
