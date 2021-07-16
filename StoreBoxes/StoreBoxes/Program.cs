using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> products = new List<Box>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                int serialNumber = int.Parse(parts[0]);
                string itemName = parts[1];
                int itemQuantity = int.Parse(parts[2]);
                decimal itemPrice = decimal.Parse(parts[3]);
                decimal priceForBox = itemPrice * itemQuantity;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.ItemQuantity = itemQuantity;
                box.Item.Price = itemPrice;
                box.PriceForBox = priceForBox;
                
                products.Add(box);
                
            }


            List<Box> sortedBox = products.OrderBy(boxes => boxes.PriceForBox).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}
