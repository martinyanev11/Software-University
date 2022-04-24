using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double singleToyPrice = double.Parse(Console.ReadLine());

            double birthdayMoney = 10;
            double totalMoney = 0;
            double numberOfToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += birthdayMoney;
                    birthdayMoney += 10;
                    totalMoney -= 1; // stolen money
                }
                else
                {
                    numberOfToys += 1;
                }
            }

            totalMoney = totalMoney + (numberOfToys * singleToyPrice);

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(totalMoney - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - totalMoney):f2}");
            }
        }
    }
}
