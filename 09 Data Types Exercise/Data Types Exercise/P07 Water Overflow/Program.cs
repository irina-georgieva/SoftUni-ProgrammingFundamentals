using System;

namespace P07_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputlitters = int.Parse(Console.ReadLine());

                if(sum + inputlitters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += inputlitters;
                }               
            }            
            Console.WriteLine(sum);
        }
    }
}
