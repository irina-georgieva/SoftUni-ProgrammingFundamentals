﻿using System;
using System.Collections.Generic;

namespace P04_List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {               
                
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}