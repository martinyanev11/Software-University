using System;

namespace _02._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuToBeManufactured = double.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double singleCPUPrice = 110.1;

            double workHoursTotal = workersNumber * workDays * 8;
            double cpuManufactured = Math.Floor(workHoursTotal / 3);

            double cpuDiff = Math.Abs(cpuManufactured - cpuToBeManufactured);
            double money = cpuDiff * singleCPUPrice;

            if (cpuManufactured < cpuToBeManufactured)
            {
                Console.WriteLine($"Losses: -> {money:f2} BGN");
            }
            else
            {
                Console.WriteLine($"Profit: -> {money:f2} BGN");
            }
        }
    }
}
