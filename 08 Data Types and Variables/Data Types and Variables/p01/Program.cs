﻿using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal km = meters / 1000;

            Console.WriteLine($"{km:F2}");

        }
    }
}
