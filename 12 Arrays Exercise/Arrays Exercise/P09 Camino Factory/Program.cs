using System;
using System.Linq;

namespace P09_Camino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();    

            int appMaxSequence = 0;         
            int mostLeftIndex = int.MaxValue;
          
            int bestDNA = 1;
            int currentDNA = 0;

            int[] result = null;
            int maxSumOfOnes = 0;            

            while(command != "Clone them!")
            {
                currentDNA++;

                int[] numbers = command
                    .Split("!" , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int sumOfOnes = 0;

                int maxSequence = 0;
                int currentSequence = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] == 0)
                    {
                        currentSequence = 0;
                        continue;
                    }                  
                    
                        sumOfOnes++;                    
                        currentSequence++;                                       

                    if(currentSequence >= maxSequence)
                    {                        
                        maxSequence = currentSequence;
                    }
                }


                string targestString = new string('1', maxSequence);// "111"
                int currentIndex = string.Join("", numbers).IndexOf(targestString); //"001011101011100"


                if (maxSequence >= appMaxSequence && currentIndex < mostLeftIndex ||
                    maxSequence == appMaxSequence && currentIndex == mostLeftIndex &&
                    sumOfOnes > maxSumOfOnes)
                {
                    appMaxSequence = maxSequence;                   
                    mostLeftIndex = currentIndex;
                    maxSumOfOnes = sumOfOnes;
                    bestDNA = currentDNA;
                    result = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDNA} with sum: {maxSumOfOnes}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
