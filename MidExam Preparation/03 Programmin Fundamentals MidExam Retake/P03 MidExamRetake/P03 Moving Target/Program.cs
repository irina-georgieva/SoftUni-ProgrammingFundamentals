using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split(" ");
                string command = commandArgs[0];
                int index = int.Parse(commandArgs[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(commandArgs[2]);
                    
                    if (index >= 0 && index <= targets.Count - 1)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.Remove(targets[index]);
                        }
                    }                    
                }
                else if (command == "Add")
                {
                    int value = int.Parse(commandArgs[2]);
                    if (index >= 0 && index <= targets.Count - 1)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(command == "Strike")
                {
                    int radius = int.Parse(commandArgs[2]);
                    if(index - radius >= 0 && index + radius <= targets.Count-1 && index >= 0 && index <= targets.Count - 1)
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                if(targets.Count == 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
