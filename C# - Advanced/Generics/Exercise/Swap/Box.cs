using System;
using System.Collections.Generic;
using System.Text;

namespace Swap
{
    public class Box<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> list)
        {
            List = list;
        }

        public T Element { get; set; }
        public List<T> List { get; set; }

        public void Swap(List<T> list, int indexOne, int indexTwo)
        {
            T tempData = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = tempData;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T item in List)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }

    }
}
