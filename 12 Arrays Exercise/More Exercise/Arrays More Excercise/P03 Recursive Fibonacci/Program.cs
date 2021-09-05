using System;

namespace P03_Recursive_Fibonacci
{
    class Program
    {
        private static long[] arrayFibonacci = null;

        static long GetFibonacci(long index)
        {
            if (arrayFibonacci[index] != 0)
            {
                return arrayFibonacci[index];
            }
            if (index <= 2)
            {
                arrayFibonacci[index] = 1;
                return arrayFibonacci[index];
            }
            arrayFibonacci[index] = GetFibonacci(index - 1) + GetFibonacci(index - 2);


            return arrayFibonacci[index];
        }

        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            //arrayFibonacci = new long[n + 1];
            //GetFibonacci(n);

            //Console.WriteLine(arrayFibonacci[n]);
            Console.WriteLine(NewFibonanachi(n));
        }

        static long NewFibonanachi(long n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return NewFibonanachi(n - 1) + NewFibonanachi(n - 2);
        }
    }
}
