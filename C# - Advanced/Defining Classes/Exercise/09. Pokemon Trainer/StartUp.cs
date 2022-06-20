using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainersList = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = input.Split();

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHeath = int.Parse(cmdArgs[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHeath);

                if (!trainersList.Any(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainersList.Add(trainer);
                }
                else
                {
                    trainersList.First(x => x.Name == trainerName).Pokemons.Add(pokemon);
                }
            }


            while ((input = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainersList)
                {
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            var orderedList = trainersList.OrderByDescending(x => x.Badges);
            foreach (Trainer trainer in orderedList)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
