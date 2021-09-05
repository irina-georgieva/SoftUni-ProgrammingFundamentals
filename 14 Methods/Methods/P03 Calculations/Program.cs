using System;

namespace P03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());   
                        
            if(command == "add")
            {
                Add(firstNumber, secondNumber);
            }

            if(command == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }

            if(command == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }

            if(command == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Add(int firstNumber, int secondNumber)
        {
            int result;
            result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        static void Multiply(int firstNumber, int secondNumber)
        {
            int result;
            result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        static void Subtract(int firstNumber, int secondNumber)
        {
            int result;
            result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        static void Divide(int firstNumber, int secondNumber)
        {
            int result;
            result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}
