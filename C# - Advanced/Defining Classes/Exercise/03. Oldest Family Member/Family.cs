using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> FamilyMembers { get; set; }

        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            //int oldestAge = int.MinValue;
            int oldestAge = this.FamilyMembers.Max(x => x.Age);
            return this.FamilyMembers.First(x => x.Age == oldestAge);
        }
    }
}
