using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int waitingTime = 30 + minutes;

            if (waitingTime > 59)
            {
                waitingTime -= 60;
                hour++;
            }
            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{waitingTime:d2}");
        }
    }
}
