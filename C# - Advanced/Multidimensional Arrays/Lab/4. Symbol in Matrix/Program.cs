using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a square matrix
            int squareMatrixDimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[squareMatrixDimensions, squareMatrixDimensions];

            // Fill the matrix with elements
            for (int rows = 0; rows < squareMatrixDimensions; rows++)
            {
                string input = Console.ReadLine();
                char[] inputArr = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    inputArr[i] = input[i];
                }

                for (int col = 0; col < squareMatrixDimensions; col++)
                {
                    matrix[rows, col] = inputArr[col];
                }
            }

            char chToFind = char.Parse(Console.ReadLine());
            int row = 0;
            int column = 0;
            bool charFound = false;

            for (int x = 0; x < squareMatrixDimensions; x++)
            {
                for (int z = 0; z < squareMatrixDimensions; z++)
                {
                    if (matrix[x, z] == chToFind)
                    {
                        charFound = true;
                        row = x;
                        column = z;
                        break;
                    }
                }

                if (charFound == true)
                {
                    break;
                }
            }

            if (charFound == true)
            {
                Console.WriteLine($"({row}, {column})");
            }
            else
            {
                Console.WriteLine($"{chToFind} does not occur in the matrix");
            }
        }
    }
}
