using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Basics - Conditional Statements - LAB Problem 7/7");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This program will calculate area of a figure depending on the input you enter.");

            Console.WriteLine("Please specify what figure you want to calculate (square, rectangle, circle or triangle):");
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                Console.WriteLine("You chose square, now enter the lenght of the side:");
                double a = double.Parse(Console.ReadLine());

                Console.Write("The area is: ");
                double squareArea = a * a;
                Console.WriteLine(squareArea);
            }
            else if (figure == "rectangle")
            {
                Console.WriteLine("You chose rectangle, now enter the lenght of one side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter lenght of other side:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("The area is: ");
                double squareArea = a * b;
                Console.WriteLine(squareArea);
            }
            else if (figure == "circle")
            {
                Console.WriteLine("You chose circle, now enter the radius:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("The area is: ");
                double squareArea = a * a * Math.PI;
                Console.WriteLine(squareArea);
            }
            else if (figure == "triangle")
            {
                Console.WriteLine("You chose triangle, now enter the lenght of a side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height perpendicular to the side:");
                double b = double.Parse(Console.ReadLine());
                Console.Write("The area is: ");
                double squareArea = a * b / 2;
                Console.WriteLine(squareArea);
            }
        }
    }
}
