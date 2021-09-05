using System;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentUserName in input)
            {
                if (currentUserName.Length < 3 || currentUserName.Length > 16)
                {
                    continue;
                }

                bool isValid = false;
                foreach (var symbol in currentUserName)
                {
                    if (!(char.IsDigit(symbol) || char.IsLetter(symbol)
                        || symbol == '-' || symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }

                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine(currentUserName);
                }
            }
        }
    }
}
