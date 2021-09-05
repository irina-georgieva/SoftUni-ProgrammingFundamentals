using System;

namespace P10_Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, action, secondNumber));
        }

        static double Calculate (int firstNumber, string action, int secondNumber)
        {
            double result = 0;

            if(action == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if(action == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if(action == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if(action == "-")
            {
                result = firstNumber - secondNumber;
            }

            return result;
        }
    }
}
