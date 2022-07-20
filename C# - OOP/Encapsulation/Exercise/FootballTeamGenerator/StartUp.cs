using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            try
            {
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    bool isFound = false;
                    string commandType = cmdArgs[0];
                    string teamName = cmdArgs[1];

                    switch (commandType)
                    {
                        case "Team":
                            Team team = new Team(teamName);
                            teams.Add(team);
                            break;

                        case "Add":
                            //Add;{TeamName};{PlayerName};{Endurance};{Sprint};{Dribble};{Passing};{Shooting}" 
                            string playerName = cmdArgs[2];
                            int endurance = int.Parse(cmdArgs[3]);
                            int sprint = int.Parse(cmdArgs[4]);
                            int dribble = int.Parse(cmdArgs[5]);
                            int passing = int.Parse(cmdArgs[6]);
                            int shooting = int.Parse(cmdArgs[7]);

                            Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                            foreach (Team t in teams)
                            {
                                if (t.Name == teamName)
                                {
                                    t.AddPlayer(player);
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound == false)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;

                        case "Remove":
                            string playerToRemove = cmdArgs[2];

                            foreach (Team t in teams)
                            {
                                if (t.Name == teamName)
                                {
                                    t.RemovePlayer(playerToRemove);
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound == false)
                            {
                                Console.WriteLine($"Player {playerToRemove} is not in {teamName} team.");
                            }
                            break;

                        case "Rating":
                            foreach (Team t in teams)
                            {
                                if (t.Name == teamName)
                                {
                                    Console.WriteLine($"{t.Name} - {t.Rating}");
                                    isFound = true;
                                    break;
                                }
                            }
                            if (isFound == false)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;
                    }
                    isFound = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
