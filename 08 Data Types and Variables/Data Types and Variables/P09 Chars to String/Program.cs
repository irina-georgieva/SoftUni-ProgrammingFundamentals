using System;

namespace P09_Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstLine}{secondLine}{thirdLine}");

        }
    }
}
