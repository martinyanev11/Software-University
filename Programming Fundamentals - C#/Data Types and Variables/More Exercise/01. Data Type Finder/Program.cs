using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            while (start)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    start = false;
                    break;
                }

                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else // since you cannot parse to string ... if the previous statements came up false -> IT's STRING Type.
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}
