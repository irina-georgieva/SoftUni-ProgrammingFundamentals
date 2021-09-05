using System;
using System.Text;

namespace P04_Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();          
            string encryptedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char newChar = (char)(((char)text[i]) + 3);

                encryptedText += newChar;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
