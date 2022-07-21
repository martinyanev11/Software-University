using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private int food;
        private string name;
        private int age;
        private string groupName;

        public Rebel(string name, int age, string groupName)
        {
            this.Name = name;
            this.age = age;
            this.groupName = groupName;
            this.Food = 0;
        }

        public int Food
        {
            get { return food; }
            private set { food = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
