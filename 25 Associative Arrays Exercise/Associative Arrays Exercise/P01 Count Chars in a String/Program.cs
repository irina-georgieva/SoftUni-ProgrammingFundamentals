using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> results = new Dictionary<char, int>();

            List<string> inputText = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < inputText.Count; i++)
            {
                for (int j = 0; j < inputText[i].Length; j++)
                {
                    if (!results.ContainsKey(inputText[i][j]))
                    {
                        results.Add(inputText[i][j], 1);
                    }
                    else
                    {
                        results[inputText[i][j]]++;
                    }
                }
            }

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
