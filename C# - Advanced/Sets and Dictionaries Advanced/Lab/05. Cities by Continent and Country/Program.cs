using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            int linesToRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesToRead; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string continentName = cmdArgs[0];
                string countryName = cmdArgs[1];
                string cityName = cmdArgs[2];

                // Add continent to the dictionary if it doesn't exist
                if (!continentDictionary.ContainsKey(continentName))
                {
                    continentDictionary.Add(continentName, new Dictionary<string, List<string>>());
                }

                // Add country to continent if it doesn't exist
                if (!continentDictionary[continentName].ContainsKey(countryName))
                {
                    continentDictionary[continentName].Add(countryName, new List<string>());
                }

                // Add city to the list in the country
                continentDictionary[continentName][countryName].Add(cityName);
                //if (!continentDictionary[continentName][countryName].Contains(cityName))
                //{
                    
                //}

            }
            // Print the result (revision)
            foreach (var continent in continentDictionary)
            {
                Console.WriteLine($"{continent.Key}: ");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
