using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetExpenses = 0;
            double mouseExpenses = 0;
            double keyboardExpenses = 0;
            double displayExpenses = 0;

            double totalExpenses = 0;

            // GEAR COUNTER
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 12 == 0)
                {
                    displayCount++;
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;
                }
                else if (i % 6 == 0)
                {
                    headsetCount++;
                    mouseCount++;
                    keyboardCount++;
                }
                else if (i % 3 == 0)
                {
                    mouseCount++;
                }
                else if (i % 2 == 0)
                {
                    headsetCount++;
                }
            }
            // CALCULATIONS OF EXPENSES
            headsetExpenses = headsetCount * headsetPrice;
            mouseExpenses = mouseCount * mousePrice;
            keyboardExpenses = keyboardCount * keyboardPrice;
            displayExpenses = displayCount * displayPrice;

            totalExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
