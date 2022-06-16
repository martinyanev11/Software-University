using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(27);
            Person person2 = new Person("Martin", 27);
        }
    }
}
