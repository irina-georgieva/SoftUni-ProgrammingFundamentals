using System;
using System.Text.RegularExpressions;

namespace P01_Match_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
           

            MatchCollection validNames = Regex.Matches(names, pattern);

            foreach (Match item in validNames)
            {
                Console.Write(item.Value +" ");
            }

            Console.WriteLine();
        }
    }
}
