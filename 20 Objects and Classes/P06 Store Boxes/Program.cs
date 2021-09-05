using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Store_Boxes
{
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

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> products = new List<Box>();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commandArgs = command.Split(" ");
                int serialNumber = int.Parse(commandArgs[0]);
                string itemName = commandArgs[1];
                int itemQuantity = int.Parse(commandArgs[2]);
                decimal itemPrice = decimal.Parse(commandArgs[3]);                

                Box newProduct = new Box();
                newProduct.Item = new Item();

                newProduct.SerialNumber = serialNumber;
                newProduct.Item.Name = itemName;
                newProduct.Quantity = itemQuantity;
                newProduct.Item.Price = itemPrice;
                newProduct.PriceBox = newProduct.Quantity * newProduct.Item.Price;

                products.Add(newProduct);

                command = Console.ReadLine();
            }

            products = products.OrderByDescending(c => c.PriceBox).ToList();
            
            foreach (var product in products)
            {
                Console.WriteLine(product.SerialNumber);
                Console.WriteLine($"-- {product.Item.Name} - ${product.Item.Price:F2}: {product.Quantity}");
                Console.WriteLine($"-- ${product.PriceBox:F2}");
            }
        }
    }
}
