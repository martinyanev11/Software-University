using System;
using System.Collections.Generic;
using System.Linq;


namespace _10._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitationsList = Console.ReadLine().Split().ToList();

            List<string> tempFilterList = new List<string>(); // List to temp store commands in

            // command fomat: "{command;filter type;filter parameter}"
            string cmdInput;
            while ((cmdInput = Console.ReadLine()) != "Print")
            {
                string[] arguments = cmdInput.Split(";");
                string action = arguments[0];
                string filterType = arguments[1];
                string parameter = arguments[2];

                if (action == "Add filter")
                {
                    AddFilter(filterType, parameter, tempFilterList); //Add cmd to temp filter list
                }
                else
                {
                    RemoveFilter(filterType, parameter, tempFilterList); // Remove cmd from temp filter list
                }
            }

            ApplyFilters(tempFilterList, invitationsList);

            Console.WriteLine(string.Join(" ", invitationsList));
        }

        private static void AddFilter(string filterType, string parameter, List<string> tempFilterList)
        {
            switch (filterType)
            {
                case "Starts with":
                    tempFilterList.Add("StartsWith;" + parameter.ToString());
                    break;

                case "Ends with":
                    tempFilterList.Add("EndsWith;" + parameter.ToString());
                    break;

                case "Length":
                    tempFilterList.Add("Length;" + parameter.ToString());
                    break;

                case "Contains":
                    tempFilterList.Add("Contains;" + parameter.ToString());
                    break;
            }
        }
        private static void RemoveFilter(string filterType, string parameter, List<string> tempFilterList)
        {
            switch (filterType)
            {
                case "Starts with":
                    tempFilterList.Remove("StartsWith;" + parameter.ToString());
                    break;

                case "Ends with":
                    tempFilterList.Remove("EndsWith;" + parameter.ToString());
                    break;

                case "Length":
                    tempFilterList.Remove("Length;" + parameter.ToString());
                    break;

                case "Contains":
                    tempFilterList.Remove("Contains;" + parameter.ToString());
                    break;
            }
        }
        private static void ApplyFilters(List<string> tempFilterList, List<string> invitationsList)
        {
            for (int i = 0; i < tempFilterList.Count; i++)
            {
                string[] filterArgs = tempFilterList[i].Split(";");
                string filterType = filterArgs[0];
                string parameter = filterArgs[1];

                switch (filterType)
                {
                    case "StartsWith":
                        Predicate<string> startsWith = name => name.StartsWith(parameter);
                        invitationsList.RemoveAll(startsWith);
                        break;

                    case "EndsWith":
                        Predicate<string> endsWith = name => name.EndsWith(parameter);
                        invitationsList.RemoveAll(endsWith);
                        break;

                    case "Length":
                        Predicate<string> length = name => name.Length == int.Parse(parameter);
                        invitationsList.RemoveAll(length);
                        break;

                    case "Contains":
                        Predicate<string> contains = name => name.Contains(parameter);
                        invitationsList.RemoveAll(contains);
                        break;
                }
            }
        }
    }
}
