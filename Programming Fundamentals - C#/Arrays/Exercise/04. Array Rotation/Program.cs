using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] newArray = new int[array.Length];
                int firstIndex = array[0];
                for (int j = 0; j < newArray.Length - 1; j++)
                {
                    newArray[j] = array[j + 1];
                }
                newArray[newArray.Length - 1] = firstIndex;
                array = newArray;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
