using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sumOfOpeningBrakets = 0;
            int sumOfClosingBrakets = 0;

            int openingBracketCounter = 1;
            int closingBracketCounter = 1;

            // consecutive opening brackets
            //bool thereIsTwo = false;

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                if (char.TryParse(input, out _))
                {
                    char ch = char.Parse(input);
                    if ((int)ch == 40)
                    {
                        sumOfOpeningBrakets += (int)ch;
                        openingBracketCounter++;
                    }
                    else if ((int)ch == 41)
                    {
                        sumOfClosingBrakets += (int)ch;
                        closingBracketCounter++;
                        if (closingBracketCounter - openingBracketCounter > 0)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                    //if (openingBracketCounter > 1 + closingBracketCounter)
                    //{
                    //}

                }
            }
            //if (thereIsTwo == false)
            //{
            if (sumOfOpeningBrakets % 40 == 0 && sumOfClosingBrakets % 41 == 0 && openingBracketCounter == closingBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            //}
            //else if (thereIsTwo == true)
            //{
            //    Console.WriteLine("UNBALANCED");
            //}

        }
    }
}
