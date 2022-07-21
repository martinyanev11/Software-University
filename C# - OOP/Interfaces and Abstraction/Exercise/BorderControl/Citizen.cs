using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IInhabitants, IBorn, IBuyer
    {
        private string id;
        private string name;
        private int age;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Birthdate 
        {
            get { return birthdate; }
            private set { birthdate = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Food 
        {
            get { return food; }
            private set { food = value; }
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
