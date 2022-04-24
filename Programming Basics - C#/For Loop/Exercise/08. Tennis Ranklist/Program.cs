using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTournaments = double.Parse(Console.ReadLine());
            double startingEloPoints = double.Parse(Console.ReadLine());

            double totalElo = 0;
            double eloGained = 0;
            double winRate = 0;

            double W = 2000; //winner
            double F = 1200; //finalist
            double SF = 720; //semifinalist

            for (int i = 0; i < numberOfTournaments; i++)
            {
                string tournamentPlacement = Console.ReadLine();

                switch (tournamentPlacement)
                {
                    case "W":
                        eloGained += W;
                        ++winRate;
                        break;
                    case "F":
                        eloGained += F;
                        break;
                    case "SF":
                        eloGained += SF;
                        break;
                }
            }

            double eloGainAverage = Math.Floor(eloGained / numberOfTournaments);
            double winRatePercent = (winRate / numberOfTournaments * 100);
            totalElo = startingEloPoints + eloGained;

            Console.WriteLine($"Final points: {totalElo}");
            Console.WriteLine($"Average points: {eloGainAverage}");
            Console.WriteLine($"{winRatePercent:f2}%");
        }
    }
}
