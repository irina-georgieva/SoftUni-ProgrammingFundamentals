﻿using System;
using System.Linq;

namespace P04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int j = 0; j < rotations; j++)
            {
                int firstNumber = input[0];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = firstNumber;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
