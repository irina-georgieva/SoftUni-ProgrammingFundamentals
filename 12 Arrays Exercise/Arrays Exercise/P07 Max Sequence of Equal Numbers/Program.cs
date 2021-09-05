using System;
using System.Linq;

namespace P07_Max_Sequence_of_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int maxElements = 0;
            int currentEqualElements = 1;
            int element = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentEqualElements++;
                }
                else
                {
                    currentEqualElements = 1;
                }

                if (currentEqualElements > maxElements)
                {
                    maxElements = currentEqualElements;
                    element = input[i];
                }
            }

                for (int i = 0; i < maxElements; i++)
                {
                    Console.Write(element + " ");

                }


            
        }
    }
}
