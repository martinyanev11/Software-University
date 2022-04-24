using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                char letter = word[letterIndex];

                switch (letter)
                {
                    case 'a':
                        sum = sum + 1;
                        break;
                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
