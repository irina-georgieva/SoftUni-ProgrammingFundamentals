using System;
using System.Text.RegularExpressions;

namespace P01_Match_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string pattern = @"\+[3][5][9](\-|\ )[2]\1\d{3}\1\d{4}";


            MatchCollection validPhones = Regex.Matches(phones, pattern);

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}
