using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char firstLetter = 'a';
            char secondLetter = 'a';
            char thirdLetter = 'a';

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    for (int k = 0; k < n; k++)
                    {
                        firstLetter = (char)('a' + i);
                        secondLetter = (char)('a' + j);
                        thirdLetter = (char)('a' + k);

                        Console.Write(firstLetter);
                        Console.Write(secondLetter);
                        Console.Write(thirdLetter);
                        Console.WriteLine();
                    }

                }

            }
        }
    }
}
