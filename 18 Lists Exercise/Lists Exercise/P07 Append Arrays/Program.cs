using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> newArrays = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                int[] numbers = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var number in numbers)
                {
                    newArrays.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", newArrays));

        }
    }
}
