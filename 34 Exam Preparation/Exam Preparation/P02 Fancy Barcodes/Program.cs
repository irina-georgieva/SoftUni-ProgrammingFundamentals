using System;
using System.Text.RegularExpressions;

namespace P02_Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^@#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@#+$";
            string digitsPattern = "[0-9]";
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentInput = Console.ReadLine();

                Match match = Regex.Match(currentInput, pattern);
                
                if(!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                MatchCollection matches = Regex.Matches(currentInput, digitsPattern);
                
                Console.Write($"Product group: ");

                if (matches.Count == 0)
                {
                    Console.WriteLine("00");                   
                    continue;
                }
              
                foreach (Match item in matches)
                {
                    Console.Write(item.Value);
                }

                Console.WriteLine();
                
            }
        }
    }
}
