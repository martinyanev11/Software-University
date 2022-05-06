using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                int[] cmdArgs = new int[command.Length];

                for (int i = 0; i < command.Length; i++)
                {
                    cmdArgs[i] = command[i];
                }
                bool isPalindrome = PalindromeCheck(cmdArgs);
                if (isPalindrome == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool PalindromeCheck(int[] cmdArgs)
        {
            int counter = 0;
            for (int i = 0; i < cmdArgs.Length / 2; i++)
            {
                if (cmdArgs[i + counter] != cmdArgs[(cmdArgs.Length - 1) - counter])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
