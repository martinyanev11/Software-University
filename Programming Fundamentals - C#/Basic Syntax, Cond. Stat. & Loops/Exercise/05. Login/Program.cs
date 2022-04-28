using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            // FROM INTERNET
            string password = "";
            int length;

            length = username.Length - 1;

            while (length >= 0)
            {
                password = password + username[length];
                length--;
            }

            // Console.WriteLine(password);
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                string pwCheck = Console.ReadLine();
                if (pwCheck == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }

        }
    }
}
