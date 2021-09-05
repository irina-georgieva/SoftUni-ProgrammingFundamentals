﻿using System;

namespace P10_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }

            if(times > 10)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
            }
        }
    }
}
