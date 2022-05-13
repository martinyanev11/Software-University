using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuatity { get; set; }
        public double PriceForABox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string data;
            while ((data = Console.ReadLine()) != "end")
            {
                // Sort out all the data input
                string[] dataSplit = data.Split();

                int serialNumber = int.Parse(dataSplit[0]);
                string itemName = dataSplit[1];
                int itemQuantity = int.Parse(dataSplit[2]);
                double itemPrice = double.Parse(dataSplit[3]);

                // Create Item and assign properties to it
                Item newItem = new Item();
                newItem.Name = itemName;
                newItem.Price = itemPrice;

                // Create Box and assign properties to it
                Box newBox = new Box();
                newBox.SerialNumber = serialNumber;
                newBox.ItemQuatity = itemQuantity;
                newBox.Item = newItem;
                newBox.PriceForABox = (double)itemQuantity * itemPrice;

                boxes.Add(newBox);
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuatity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
