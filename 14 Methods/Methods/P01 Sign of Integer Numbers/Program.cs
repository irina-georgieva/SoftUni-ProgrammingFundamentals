using System;

namespace P01_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintSign(inputNumber);
        }

        static void PrintSign(int inputNumber)
        {
           if(inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is negative.");
            }

           else if(inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive.");
            }
           else
            {
                Console.WriteLine($"The number {inputNumber} is zero.");
            }
        }
    }
}
