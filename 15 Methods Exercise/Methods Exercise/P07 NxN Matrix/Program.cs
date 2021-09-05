using System;

namespace P07_NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BuildMatrix(n);
        }

        private static void BuildMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
