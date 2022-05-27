using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestListVIP = new HashSet<string>();
            HashSet<string> guestListRegular = new HashSet<string>();

            string reservationNumber;
            while ((reservationNumber = Console.ReadLine()) != "PARTY")
            {
                if (reservationNumber.Length != 8)
                    continue;
                else if (char.IsDigit(reservationNumber, 0) == true)
                    guestListVIP.Add(reservationNumber);
                else
                    guestListRegular.Add(reservationNumber);
            }

            while ((reservationNumber = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(reservationNumber, 0) == true)
                    guestListVIP.Remove(reservationNumber);
                else
                    guestListRegular.Remove(reservationNumber);
            }

            int guestsWhoDidntShowUp = guestListVIP.Count + guestListRegular.Count;
            Console.WriteLine(guestsWhoDidntShowUp);
            foreach (var guest in guestListVIP)
                Console.WriteLine(guest);
            foreach (var guest in guestListRegular)
                Console.WriteLine(guest);
        }
    }
}
