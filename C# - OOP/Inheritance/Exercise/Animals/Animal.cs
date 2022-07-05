using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input!");
                }
                else
                {
                    name = value;
                }

            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid input!");
                }
                else
                {
                    age = value;
                }

            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input!");
                }
                else
                {
                    gender = value;
                }
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.name} {this.Age} {this.Gender}");
            sb.Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}
