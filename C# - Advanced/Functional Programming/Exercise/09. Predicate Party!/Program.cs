using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string criteria = cmdArgs[1];
                string criteriaValue = cmdArgs[2];

                switch (action)
                {
                    case "Remove":
                        RemoveFromList(criteria, criteriaValue, guestList);
                        break;

                    case "Double":
                        DoubleNamesInList(criteria, criteriaValue, guestList);
                        break;
                }

                if (guestList.Count == 0)
                {
                    break;
                }
            }

            if (guestList.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void RemoveFromList(string criteria, string criteriaValue, List<string> guestList)
        {
            if (criteria == "StartsWith")
            {
                Predicate<string> predicate = name => name.StartsWith(criteriaValue);
                guestList.RemoveAll(predicate);
            }
            else if (criteria == "EndsWith")
            {
                Predicate<string> predicate = name => name.EndsWith(criteriaValue);
                guestList.RemoveAll(predicate);
            }
            else if (criteria == "Length")
            {
                Predicate<string> predicate = x => x.Length == int.Parse(criteriaValue);
                guestList.RemoveAll(predicate);
            }
        }

        private static void DoubleNamesInList(string criteria, string criteriaValue, List<string> guestList)
        {
            if (criteria == "StartsWith")
            {
                Predicate<string> predicate = name => name.StartsWith(criteriaValue);
                int currentListCount = guestList.Count;
                for (int i = 0; i < currentListCount; i++)
                {
                    string name = guestList[i];
                    if (predicate(name))
                    {
                        guestList.Add(name);
                    }
                }
                guestList.Sort();
            }
            else if (criteria == "EndsWith")
            {
                Predicate<string> predicate = name => name.EndsWith(criteriaValue);
                int currentListCount = guestList.Count;
                for (int i = 0; i < currentListCount; i++)
                {
                    string name = guestList[i];
                    if (predicate(name))
                    {
                        guestList.Add(name);
                    }
                }
                guestList.Sort();
            }
            else if (criteria == "Length")
            {
                Predicate<string> predicate = x => x.Length == int.Parse(criteriaValue);
                int currentListCount = guestList.Count;
                for (int i = 0; i < currentListCount; i++)
                {
                    string name = guestList[i];
                    if (predicate(name))
                    {
                        guestList.Add(name);
                    }
                }
                guestList.Sort();
            }
        }
    }
}
