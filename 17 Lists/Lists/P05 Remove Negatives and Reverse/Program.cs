using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToList();

            List<int> result = new List<int>();

            foreach (var element in numbers)
            {
                if(element > 0)
                {
                    result.Add(element);
                }
            }

            result.Reverse();


            if(result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }

    }
}
