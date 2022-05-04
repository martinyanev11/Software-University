using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading input
            int numberOfInputs = int.Parse(Console.ReadLine());

            string[] names = new string[numberOfInputs];
            int[] encrypted = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                names[i] = Console.ReadLine();
            }

            int counter = 0; // This counter keeps track of which index we should add "currNameSum" into the encrypted array
            foreach (string name in names)
            {
                int currNameSum = 0;
                bool isVowel = false;

                for (int i = 0; i < name.Length; i++)
                {
                    // Check if the char on index i is a vowel or consonant
                    if ("aeiouAEIOU".Contains(name[i].ToString()))
                    {
                        isVowel = true;
                    }
                    else
                    {
                        isVowel = false; // This will make sure it goes into the right if statement below (restarting the bool)
                    }

                    if (isVowel == true)
                    {
                        currNameSum += name[i] * name.Length;
                    }
                    else
                    {
                        currNameSum += name[i] / name.Length;
                    }
                }

                encrypted[counter] = currNameSum;
                counter++;
            }

            Array.Sort(encrypted);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{encrypted[i]}"); 
            }
        }
    }
}
