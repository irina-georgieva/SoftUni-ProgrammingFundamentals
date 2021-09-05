using System;

namespace P03_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            string charLine = RangeCharacters(one, two);

            Console.WriteLine(charLine);
        }

        private static string RangeCharacters(char one, char two)
        {
            string newLine = string.Empty;

            if (two > one)
            {
                for (int i = one; i < two - 1; i++)
                {
                    newLine += ((char)(i + 1)) + " ";
                }
            }

            else if(one > two)
            {
                for (int i = two; i < one - 1; i++)
                {
                    newLine += ((char)(i + 1)) + " ";
                }
            }

            return newLine;

            
        }
    }
}
