using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animalsList = new List<Animal>();

            string command;
            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                string gender = cmdArgs[2];

                switch (command)
                {
                    case "Dog":
                        break;

                    case "Cat":
                        break;

                    case "Frog":
                        break;

                    case "Kittens":
                        break;

                    case "Tomcat":
                        break;
                }
            }
        }
    }
}
