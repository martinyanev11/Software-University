using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person(name, age));
            }
            string condition = Console.ReadLine();
            int ageThreshhold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();


            Func<Person, bool> filter = Filter(condition, ageThreshhold);
            List<Person> filteredPeople = people.Where(filter).ToList();

            Action<Person> printer = Printer(format);

            PrintFilteredPeople(filteredPeople, printer);
        }

        private static Func<Person, bool> Filter(string condition, int ageThreshhold)
        {
            if (condition == "older")
                return x => x.Age >= ageThreshhold;
            else // if yonger
                return x => x.Age < ageThreshhold;
        }

        private static Action<Person> Printer(string format)
        {
            if (format == "name age")
                return p => Console.WriteLine($"{p.Name} - {p.Age}");

            if (format == "name")
                return p => Console.WriteLine($"{p.Name}");

            if (format == "age")
                return p => Console.WriteLine($"{p.Age}");

            throw new ArgumentException($"Invalid format: {format}");
        }

        private static void PrintFilteredPeople(List<Person> filteredPeople, Action<Person> printer)
        {
            foreach (var person in filteredPeople)
            {
                printer(person);
            }
        }
    }
}
