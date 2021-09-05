using System;

namespace P08_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(firstNumber, secondNumber));                       
        }

        static double MathPower(double firstNumber, int secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }
    }
}
