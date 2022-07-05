using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // PROBLEM 1.Sort Persons by Name and Age INPUT:

            //var lines = int.Parse(Console.ReadLine());
            //var persons = new List<Person>();
            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            //    persons.Add(person);
            //}

            //persons.OrderBy(p => p.FirstName)
            //       .ThenBy(p => p.Age)
            //       .ToList()
            //       .ForEach(p => Console.WriteLine(p.ToString()));



            //-----------------------------------------------------------------------------------------
            /* PROBLEM 2.Salary Increase
             & 3.Validation of Data INPUT:*/

            //var lines = int.Parse(Console.ReadLine());
            //var persons = new List<Person>();
            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

            //    persons.Add(person);
            //}
            //var parcentage = decimal.Parse(Console.ReadLine());
            //persons.ForEach(p => p.IncreaseSalary(parcentage));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));


            //-----------------------------------------------------------------------------------------
            // PROBLEM 4.First and Reserve Team INPUT:

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
