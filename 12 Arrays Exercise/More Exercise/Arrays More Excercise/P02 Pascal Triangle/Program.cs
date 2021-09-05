using System;

namespace P02_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int printValue = 0;

            for (int i = 0; i < n; i++)
            {
               // for (int blank = 1; blank <= n - i; blank++)
               //     Console.Write(" ");
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        printValue = 1;
                    else
                        printValue = printValue * (i - j + 1) / j;
                    Console.Write(printValue + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
