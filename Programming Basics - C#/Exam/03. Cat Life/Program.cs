using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string catBreed = Console.ReadLine();
            char sex = char.Parse(Console.ReadLine());

            int humanYears = 0;
            int humanMonths = 0;
            int catMonths = 0;
            

            switch (catBreed)
            {
                case "British Shorthair":
                    if (sex == 'm')
                    {
                        humanYears = 13;
                    }
                    else
                    {
                        humanYears = 14;
                    }
                    break;
                case "Siamese":
                    if (sex == 'm')
                    {
                        humanYears = 15;
                    }
                    else
                    {
                        humanYears = 16;
                    }
                    break;
                case "Persian":
                    if (sex == 'm')
                    {
                        humanYears = 14;
                    }
                    else
                    {
                        humanYears = 15;
                    }
                    break;
                case "Ragdoll":
                    if (sex == 'm')
                    {
                        humanYears = 16;
                    }
                    else
                    {
                        humanYears = 17;
                    }
                    break;
                case "American Shorthair":
                    if (sex == 'm')
                    {
                        humanYears = 12;
                    }
                    else
                    {
                        humanYears = 13;
                    }
                    break;
                case "Siberian":
                    if (sex == 'm')
                    {
                        humanYears = 11;
                    }
                    else
                    {
                        humanYears = 12;
                    }
                    break;

                default:
                    Console.WriteLine($"{catBreed} is invalid cat!");
                    break;
            }

            humanMonths = humanYears * 12;
            catMonths = humanMonths / 6;

            if (catBreed == "British Shorthair" || catBreed == "Siamese" || catBreed == "Persian" || catBreed == "Ragdoll" || catBreed == "American Shorthair" || catBreed == "Siberian")
            {
                Console.WriteLine(catMonths + " cat months");
            }
            


        }
    }
}
