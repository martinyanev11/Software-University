using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBorn
    {
        private string birthdate;
        private string name;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
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
    }
}
