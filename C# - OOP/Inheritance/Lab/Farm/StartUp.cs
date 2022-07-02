using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Problem 01. Single Inheritance:
            //Dog dog = new Dog();
            //dog.Eat();
            //dog.Bark();

            // Problem 02. Multiple Inheritance:
            //Puppy puppy = new Puppy();
            //puppy.Eat();
            //puppy.Bark();
            //puppy.Weep();

            // Problem 03. Hierarchical Inheritance:
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
