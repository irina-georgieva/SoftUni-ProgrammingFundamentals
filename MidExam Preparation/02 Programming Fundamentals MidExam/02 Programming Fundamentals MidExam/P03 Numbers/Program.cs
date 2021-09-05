using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            double sumNumbers = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sumNumbers += numbers[i];
            }

            double averageNumbers = sumNumbers / numbers.Count;

            List<int> greaterNumbers = new List<int>();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > averageNumbers)
                {
                    greaterNumbers.Add(numbers[i]);
                }
            }

            if (greaterNumbers.Count > 5)
            {
                
                    greaterNumbers.Sort();
                    greaterNumbers.Reverse();

                greaterNumbers.RemoveRange(5, greaterNumbers.Count-5);                
            }

            if(greaterNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                greaterNumbers.Sort();
                greaterNumbers.Reverse();

                Console.WriteLine(string.Join(" ", greaterNumbers));
            }
        }
    }
}
