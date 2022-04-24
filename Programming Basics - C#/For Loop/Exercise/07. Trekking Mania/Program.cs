using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());

            double totalClimbers = 0;

            double musala = 0; // <= 5
            double monblan = 0; // 6 - 12 vkl.
            double kilimandjaro = 0; // 13 - 25 vkl
            double k2 = 0; // 26 - 40 vkl
            double everest = 0; // >= 41

            for (int i = 0; i < groupsNumber; i++)
            {
                int groupMembersNumber = int.Parse(Console.ReadLine());
                totalClimbers += groupMembersNumber;

                if (groupMembersNumber <= 5)
                {
                    musala += groupMembersNumber;
                }
                else if (groupMembersNumber >= 6 && groupMembersNumber <= 12)
                {
                    monblan += groupMembersNumber;
                }
                else if (groupMembersNumber >= 13 && groupMembersNumber <= 25)
                {
                    kilimandjaro += groupMembersNumber;
                }
                else if (groupMembersNumber >= 26 && groupMembersNumber <= 40)
                {
                    k2 += groupMembersNumber;
                }
                else if (groupMembersNumber >= 41)
                {
                    everest += groupMembersNumber;
                }
            }

            Console.WriteLine($"{(musala / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(monblan / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(kilimandjaro / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(k2 / totalClimbers * 100):f2}%");
            Console.WriteLine($"{(everest / totalClimbers * 100):f2}%");
        }
    }
}
