using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number of input from console

            Dictionary<string, List<decimal>> studentBook = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal studentGrade = decimal.Parse(input[1]);

                if (!studentBook.ContainsKey(studentName))
                {
                    studentBook.Add(studentName, new List<decimal>());
                }
                studentBook[studentName].Add(studentGrade);
            }

            foreach (var studentKVP in studentBook)
            {
                Console.Write($"{studentKVP.Key} -> ");
                foreach (var grade in studentKVP.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {studentKVP.Value.Average():f2})");
            }
        }
    }
}
