using System;
using System.Collections.Generic;

namespace P02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string wordLower = item.ToLower();

                if(counts.ContainsKey(wordLower))
                {
                    counts[wordLower]++;
                }
                else
                {
                    counts.Add(wordLower, 1);
                }
            }

            foreach (var word in counts)
            {
                if(word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
