using System;
using System.Collections.Generic;
using System.Linq;

namespace P4_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToList();

            int count = 0;

            if(numbers.Count >= 3)
            {
                count = 3;
            }
            else
            {
                count = numbers.Count;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
                
        }
    }
}
