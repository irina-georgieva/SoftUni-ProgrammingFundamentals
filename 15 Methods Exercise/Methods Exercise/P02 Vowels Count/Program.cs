using System;

namespace P02_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int result = GetVowels(word);

            Console.WriteLine(result);
        }

        private static int GetVowels(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                string currentLetter = word[i].ToString().ToLower();
                switch(currentLetter)
                {
                    case "a":
                    case "o":
                    case "u":
                    case "i":
                    case "e":
                        count++;
                        break;
                }
            }

            return count;
        }
    }
}
