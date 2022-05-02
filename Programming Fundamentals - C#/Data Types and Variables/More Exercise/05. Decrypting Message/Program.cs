using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                decrypted += letter;
            }
            Console.WriteLine(decrypted);
        }
    }
}
