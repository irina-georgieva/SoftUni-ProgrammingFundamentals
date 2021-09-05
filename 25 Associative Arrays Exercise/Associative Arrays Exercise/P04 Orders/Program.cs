using System;
using System.Collections.Generic;

namespace P04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            string input = Console.ReadLine();

            while(input != "buy")
            {
                string[] inputInfo = input.Split();
                string productName = inputInfo[0];
                double productPrice = double.Parse(inputInfo[1]);
                double productQuantity = double.Parse(inputInfo[2]);

                if(!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                double previousQty = products[productName][1];
                double[] priceQty = new double[] { productPrice, previousQty + productQuantity };
                products[productName] = priceQty;


                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
            }
        }

    }
}
