using System;
using System.Linq;

namespace P08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
                        
            int currentNumber = 0;
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == n)
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j]);                        
                    }
                   
                }                
            }

        }
    }
}
