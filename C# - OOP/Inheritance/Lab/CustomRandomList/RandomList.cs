using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString(List<string> list)
        {
            Random random = new Random();
            int indexToRemove = random.Next(0, list.Count);

            string removedString = list[indexToRemove];
            list.RemoveAt(indexToRemove);
            return removedString;
        }
    }
}
