using System;

namespace P01_Activation_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandInfo = command.Split(">>>");
                string action = commandInfo[0];

                if(action == "Slice")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    for (int i = endIndex - 1; i >= startIndex; i--)
                    {
                        input = input.Remove(i, 1);
                    }

                    Console.WriteLine(input);

                }
                else if(action == "Flip")
                {
                    string upperLower = commandInfo[1];
                    int startIndex = int.Parse(commandInfo[2]);
                    int endIndex = int.Parse(commandInfo[3]);

                    if(upperLower == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentChar = char.ToUpper(input[i]);
                            input = input.Remove(i, 1);
                            input = input.Insert(i, currentChar.ToString());
                        }

                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            char currentChar = char.ToLower(input[i]);
                            input = input.Remove(i, 1);
                            input = input.Insert(i, currentChar.ToString());
                        }
                    }

                    Console.WriteLine(input);

                }
                else if(action == "Contains")
                {
                    string subString = commandInfo[1];

                    if(input.Contains(subString))
                    {
                        Console.WriteLine($"{input} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");        
        }
    }
}
