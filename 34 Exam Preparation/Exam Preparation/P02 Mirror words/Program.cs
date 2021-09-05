using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            
            string pattern = "(@(?<firstName>[A-Za-z]{3,})@{2}(?<secondName>[A-Za-z]{3,})@)|(#(?<firstName>[A-Za-z]{3,})#{2}(?<secondName>[A-Za-z]{3,})#)";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                string firstValue = item.Groups["firstName"].Value;
                string secondValue = item.Groups["secondName"].Value;

                string reversedValue = string
                    .Join("", item.Groups["secondName"].Value.Reverse());
                
                bool areEqual = string.Equals(firstValue, reversedValue, 
                    StringComparison.OrdinalIgnoreCase);

                if (firstValue == reversedValue)
                {
                    result.Add($"{firstValue} <=> {secondValue}");
                }                
            }

            if(matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if(result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}
