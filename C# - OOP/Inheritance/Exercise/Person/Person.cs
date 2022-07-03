using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return strBuilder.ToString();
        }
    }
}
