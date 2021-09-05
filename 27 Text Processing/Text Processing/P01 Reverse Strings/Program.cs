﻿using System;

namespace P01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string reversed = string.Empty;

            while (line != "end")
            {
                for (int i = line.Length-1; i >= 0; i--)
                {
                    reversed += line[i];
                }
                Console.WriteLine($"{line} = { reversed}");

                reversed = string.Empty;
                line = Console.ReadLine();
            }
        }
    }
}
