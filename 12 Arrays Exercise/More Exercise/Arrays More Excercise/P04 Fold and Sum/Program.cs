using System;
using System.Linq;

namespace P04_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int fold = numbers.Length / 4;

            int[] leftRight = new int[fold * 2];
            int[] middle = new int[fold * 2];

            int i = 0;

            for (int k = fold - 1; k >= 0; k--)
            {
                leftRight[i] = numbers[k];
                i++;
            }

            for (int j = numbers.Length - 1; j > (numbers.Length - 1) - fold; j--)
            {
                leftRight[i] = numbers[j];
                i++;
            }

            i = 0;

            for (int m = fold; m <= (numbers.Length - 1) - fold; m++)
            {
                middle[i] = numbers[m];
                i++;
            }



            int[] resultLeftRightMiddle = new int[fold * 2];

            for (int n = 0; n < middle.Length; n++)
            {
                resultLeftRightMiddle[n] = leftRight[n] + middle[n];
            }

            foreach (var element in resultLeftRightMiddle)
            {
                Console.Write($"{element} ");
            }
        }
    }
 
}
