using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Problems 4 & 5 business logic:
            //List<IBorn> creatures = new List<IBorn>();

            //string dataInput;
            //while ((dataInput = Console.ReadLine()) != "End")
            //{
            //    string[] cmdArgs = dataInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    IBorn creature;

            //    if (cmdArgs[0] == "Citizen")
            //    {
            //        string name = cmdArgs[1];
            //        int age = int.Parse(cmdArgs[2]);
            //        string id = cmdArgs[3];
            //        string birthdate = cmdArgs[4];

            //        creature = new Citizen(name, age, id, birthdate);
            //    }
            //    else if (cmdArgs[0] == "Pet")
            //    {
            //        string name = cmdArgs[1];
            //        string birthdate = cmdArgs[2];

            //        creature = new Pet(name, birthdate);
            //    }
            //    else
            //    {
            //        continue;
            //    }

            //    creatures.Add(creature);
            //}

            //string yearToPrint = Console.ReadLine();
            //foreach (IBorn inhabitant in creatures)
            //{
            //    if (inhabitant.Birthdate.EndsWith(yearToPrint))
            //    {
            //        Console.WriteLine(inhabitant.Birthdate);
            //    }
            //}

            // Problem 6 logic:
            List<IBuyer> buyerList = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());
            IBuyer buyer;

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                if (cmdArgs.Length == 3)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string groupName = cmdArgs[2];

                    buyer = new Rebel(name, age, groupName);
                }
                else
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    string birthdate = cmdArgs[3];

                    buyer = new Citizen(name, age, id, birthdate);
                }

                buyerList.Add(buyer);
            }

            string buyerName;

            while ((buyerName = Console.ReadLine()) != "End")
            {
                if (buyerList.Any(x => x.Name == buyerName))
                {
                    buyerList.First(x => x.Name == buyerName).BuyFood();
                }
            }

            int totalFood = buyerList.Sum(x => x.Food);
            Console.WriteLine(totalFood);
        }
    }
}
