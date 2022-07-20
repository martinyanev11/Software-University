using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //// Exercise 1 code:
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //IPerson person = new Citizen(name, age);

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);

            // Exercise 2 code:
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);

        }
    }
}
