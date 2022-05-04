using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] pascalTriangleArray = new int[inputNumber];

            bool isEven = false;
            int printCounter = inputNumber - 1;

            if (inputNumber % 2 == 0)
            {
                isEven = true;
                printCounter--;
            }

            // Add the first number on middle index to be = 1
            pascalTriangleArray[inputNumber / 2] = 1;

            // Print the first line
            Console.WriteLine(String.Join(" ", pascalTriangleArray.Where(x => x != 0)));

            // Then if the array length is even we add another "1" on the middle index - 1
            if (isEven == true)
            {
                pascalTriangleArray[(inputNumber / 2) - 1] = 1;
            }
            
            Console.WriteLine(String.Join(" ", pascalTriangleArray.Where(x => x != 0)));

            int leftCounter = printCounter / 2 - 1;
            int rightCounter = printCounter / 2 + 1;

            for (int i = 0; i < printCounter; i++)
            {

            }
        }
    }
}
