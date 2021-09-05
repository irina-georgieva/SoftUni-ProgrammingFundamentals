using System;

namespace P01_Smallest_of_All_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GerMinNumber(a, b, c);
            
            Console.WriteLine(result);
        }

        static int GerMinNumber(int a, int b, int c)
        {
            int minNumber = b;

            if(a < b)
            {
                minNumber = a;
            }

            if(c < minNumber)
            {
                minNumber = c;
            }

            return minNumber;

        }
    }
}
