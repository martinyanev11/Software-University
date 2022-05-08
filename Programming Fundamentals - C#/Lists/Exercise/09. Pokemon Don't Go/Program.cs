using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonsList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int listSum = 0;
            while (pokemonsList.Count != 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());

                if (indexToRemove < 0)
                {
                    int indexToRemoveValue = pokemonsList[0];
                    listSum += indexToRemoveValue;
                    pokemonsList.RemoveAt(0);
                    pokemonsList.Insert(0, pokemonsList[pokemonsList.Count - 1]);
                    for (int i = 0; i < pokemonsList.Count; i++)
                    {
                        if (pokemonsList[i] <= indexToRemoveValue)
                        {
                            pokemonsList[i] += indexToRemoveValue;
                        }
                        else
                        {
                            pokemonsList[i] -= indexToRemoveValue;
                        }
                    }
                }
                else if (indexToRemove >= pokemonsList.Count)
                {
                    int indexToRemoveValue = pokemonsList[pokemonsList.Count - 1];
                    listSum += indexToRemoveValue;
                    pokemonsList.RemoveAt(pokemonsList.Count - 1);
                    pokemonsList.Add(pokemonsList[0]);
                    for (int i = 0; i < pokemonsList.Count; i++)
                    {
                        if (pokemonsList[i] <= indexToRemoveValue)
                        {
                            pokemonsList[i] += indexToRemoveValue;
                        }
                        else
                        {
                            pokemonsList[i] -= indexToRemoveValue;
                        }
                    }
                }
                else
                {
                    int indexToRemoveValue = pokemonsList[indexToRemove];
                    listSum += indexToRemoveValue;
                    pokemonsList.RemoveAt(indexToRemove);
                    for (int i = 0; i < pokemonsList.Count; i++)
                    {
                        if (pokemonsList[i] <= indexToRemoveValue)
                        {
                            pokemonsList[i] += indexToRemoveValue;
                        }
                        else
                        {
                            pokemonsList[i] -= indexToRemoveValue;
                        }
                    }
                }

            }
            Console.WriteLine(listSum);
        }
    }
}
