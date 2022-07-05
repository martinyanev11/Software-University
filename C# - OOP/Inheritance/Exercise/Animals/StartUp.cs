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
                        Dog dog = new Dog(name, age, gender);
                        animalsList.Add(dog);
                        break;

                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        animalsList.Add(cat);
                        break;

                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        animalsList.Add(frog);
                        break;

                    case "Kittens":
                        Kitten kitten = new Kitten(name, age);
                        animalsList.Add(kitten);
                        break;

                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        animalsList.Add(tomcat);
                        break;
                }
            }

            foreach (var animal in animalsList)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
