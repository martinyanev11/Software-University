using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int digitSumLeft = 0;
            int digitSumRight = 0;

            string leftNumber = string.Empty;
            string rightNumber = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                string numbers = Console.ReadLine();
                bool spaceEntered = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    char ch = (char)numbers[j];
                    if (ch == 32)
                    {
                        spaceEntered = true;
                    }
                    else if (spaceEntered == false)
                    {
                        if (ch == 45)
                        {
                            leftNumber += ch;
                        }
                        else
                        {
                            digitSumLeft += (int)ch - 48;
                            leftNumber += ch;
                        }

                    }
                    else if (spaceEntered == true)
                    {
                        if (ch == 45)
                        {
                            rightNumber += ch;
                        }
                        else
                        {
                            digitSumRight += (int)ch - 48;
                            rightNumber += ch;
                        }
                    }
                }

                long leftInt = long.Parse(leftNumber);
                long rightInt = long.Parse(rightNumber);

                if (leftInt > rightInt)
                {
                    Console.WriteLine(digitSumLeft);
                }
                else
                {
                    Console.WriteLine(digitSumRight);
                }

                digitSumLeft = 0;
                digitSumRight = 0;
                leftNumber = string.Empty;
                rightNumber = string.Empty;
            }


        }
    }
}
