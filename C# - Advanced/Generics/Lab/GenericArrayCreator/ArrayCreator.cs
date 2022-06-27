using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length].Select(x => x = item).ToArray();

            return array;
        }
    }
}
