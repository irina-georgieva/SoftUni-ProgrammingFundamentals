using System;

namespace Objects_and_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int position = rnd.Next(words.Length);

                string word = words[i];
                words[i] = words[position];
                words[position] = word;
            }

            Console.Write(string.Join('\n', words));
        }
    }
}
