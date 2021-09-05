using System;

namespace P02_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string argOne = input[0];
            string argTwo = input[1];
            int result = 0;

            if (argOne.Length == argTwo.Length)
            {
                for (int i = 0; i < argOne.Length; i++)
                {
                    result += (char)argOne[i] * (char)argTwo[i];
                }
            }
            else
            {
                // aAaad fgh
                if (argOne.Length < argTwo.Length)
                {
                    var temp = argOne;
                    argOne = argTwo;
                    argTwo = temp;
                }

                result = findResult(argOne, argTwo, result);
            }

            Console.WriteLine(result);
           
        }

        private static int findResult(string argOne, string argTwo, int result)
        {
            int remaining = argOne.Length - argTwo.Length;

            for (int i = 0; i < argTwo.Length; i++)
            {
                result += (char)argOne[i] * (char)argTwo[i];
            }

            for (int i = argOne.Length - remaining; i < argOne.Length; i++)
            {
                result += (char)argOne[i];
            }

            return result;
        }
    }


}
