using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Sign up")
            {
                string[] commandInfo = command.Split(" ");
                string action = commandInfo[0];

                if (action == "Case")
                {
                    string detail = commandInfo[1];
                    if (detail == "lower")
                    {
                        username = username.ToLower();
                    }
                    else if (detail == "upper")
                    {
                        username = username.ToUpper();
                    }

                    Console.WriteLine(username);
                }

                if (action == "Reverse")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (endIndex > username.Length)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        string modifyedUsername = username.Substring(startIndex, endIndex - startIndex + 1);
                        string reversed = new string(modifyedUsername.Reverse().ToArray());
                        Console.WriteLine(reversed);
                    }
                }

                if (action == "Cut")
                {
                    string substing = commandInfo[1];

                    if (username.Contains(substing))
                    {
                        username = username.Replace(substing, "");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substing}.");
                    }
                }

                if (action == "Replace")
                {
                    string newChar = commandInfo[1];
                    username = username.Replace(newChar, "*");
                    Console.WriteLine(username);
                }

                if (action == "Check")
                {
                    string newChar = commandInfo[1];

                    if (username.Contains(newChar))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {newChar}.");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
