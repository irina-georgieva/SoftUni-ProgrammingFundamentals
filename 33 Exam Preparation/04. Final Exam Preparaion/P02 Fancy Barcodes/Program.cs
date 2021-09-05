using System;
using System.Text.RegularExpressions;

namespace P02_Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([:*])\1([A-Z][a-z]{2,})\1{2}");

            long coolThreshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsDigit(input[i]))
                {
                    coolThreshold *= input[i] - 48;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in matches)
            {
                int coolnes = 0;
                string emoji = item.Groups[2].Value;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolnes += emoji[i];
                }

                if(coolnes >= coolThreshold)
                {
                    Console.WriteLine(item.Value);
                }
            }


        }
    }
}
