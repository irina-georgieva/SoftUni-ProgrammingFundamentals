using System;
using System.Linq;

namespace P05_SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }
            }

            Console.WriteLine(sumEven - sumOdd);

        }
    }
}
