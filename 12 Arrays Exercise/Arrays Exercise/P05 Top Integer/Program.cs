using System;
using System.Linq;

namespace P05_Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                int checkNum = numbers[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (checkNum <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    result += checkNum + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
