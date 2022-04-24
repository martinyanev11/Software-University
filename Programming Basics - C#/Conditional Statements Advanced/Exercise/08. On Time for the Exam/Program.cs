using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examStartHour = int.Parse(Console.ReadLine());
            int examStartMinutes = int.Parse(Console.ReadLine());
            // Make the time in minutes only
            int examStartConverted = examStartHour * 60 + examStartMinutes;

            int examArriveHour = int.Parse(Console.ReadLine());
            int examArriveMinutes = int.Parse(Console.ReadLine());
            // Make the time in minutes only
            int examArriveConverted = examArriveHour * 60 + examArriveMinutes;

            // Calculate the difference
            int difference = (examStartConverted - examArriveConverted);

            if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                // If he isn't right on time but just a bit early add message
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference < 0)
            {
                Console.WriteLine("Late");
                // If he came less than hour late
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                // If he is more than an hour late
                else
                {
                    int hoursLate = Math.Abs(difference) / 60;
                    int minutesLate = Math.Abs(difference) % 60;
                    Console.WriteLine($"{hoursLate}:{minutesLate:d2} hours after the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                // If he came less than hour early
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                // If he is more than an hour early
                else
                {
                    int hoursEarly = difference / 60;
                    int minutesEarly = difference % 60;
                    Console.WriteLine($"{hoursEarly}:{minutesEarly:d2} hours before the start");
                }
            }
        }
    }
}
