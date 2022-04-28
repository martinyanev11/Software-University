using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());


            double totalLightsabersPrice = (Math.Ceiling(studentsNumber * 0.1) + studentsNumber) * lightsaberPrice;
            double totalRobesPrice = studentsNumber * robePrice;
            double totalBeltPrice = (studentsNumber - (studentsNumber / 6)) * beltPrice;
            double totalPrice = totalLightsabersPrice + totalRobesPrice + totalBeltPrice;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - money):f2}lv more.");
            }
        }
    }
}
