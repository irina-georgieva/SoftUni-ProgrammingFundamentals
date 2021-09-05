using System;
using System.Linq;

namespace P04_Reverse_Array_from_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
