using System;

namespace P10_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called GetMultipleOfEvenAndOdds()
            //Create a method GetSumOfEvenDigits()
            //Create GetSumOfOddDigits()

            int number = Math.Abs(int.Parse(Console.ReadLine()));
            
            int sumOdd = GetSumOfOddDigits(number);
            int sumEven = GetSumOfEvenDigits(number);

            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOdd, sumEven));
        }

        static int GetMultipleOfEvenAndOdds(int a, int b)
        { 
            int result = a * b;
            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            string currentNumber = number.ToString();
            int sumOdd = 0;

            for (int i = 0; i < currentNumber.Length; i++)
            {
                int currentDigit = int.Parse(currentNumber[i].ToString());
                if (currentDigit % 2 != 0)
                {
                    sumOdd += currentDigit;
                }
            }

            return sumOdd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            string currentNumber = number.ToString();
            int sumEven = 0;

            for (int i = 0; i < currentNumber.Length; i++)
            {
                int currentDigit = int.Parse(currentNumber[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
            }

            return sumEven;
        }
    }
}
