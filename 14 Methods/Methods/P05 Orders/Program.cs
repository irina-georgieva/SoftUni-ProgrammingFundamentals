using System;

namespace P05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();            
            double price = 0;

            Orders(product, price);           
        }

        static void Orders(string product, double price)
        {
            int quantity = int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }
            double result = quantity * price;
            Console.WriteLine($"{result:F2}");
        }
    }
}
