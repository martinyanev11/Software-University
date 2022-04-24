using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double openTabs = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double facebook = 150;
            double instagram = 100;
            double reddit = 50;

            for (int i = 0; i < openTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

                string currentTab = Console.ReadLine();

                switch (currentTab)
                {
                    case "Facebook":
                        salary -= facebook;
                        break;
                    case "Instagram":
                        salary -= instagram;
                        break;
                    case "Reddit":
                        salary -= reddit;
                        break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
