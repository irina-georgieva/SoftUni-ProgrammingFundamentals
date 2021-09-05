using System;
using System.Linq;

namespace P07_Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool notEqual = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    notEqual = true;
                    break;
                }
                else
                {
                    sum += arr1[i];
                }
            }

            if (!notEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
