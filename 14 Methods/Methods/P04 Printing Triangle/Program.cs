﻿using System;

namespace P04_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);

        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintCol(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintCol(i);
            }
        }

        private static void PrintCol(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
