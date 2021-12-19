using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponParts = Console.ReadLine().Split("|").ToList();

            string command = Console.ReadLine();

            while(command != "Done")
            {
                string[] commandArgs = command.Split(" ");
                string action = commandArgs[0];

                if(action == "Add")
                {
                    string particle = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);

                    if(index >= 0 && index < weaponParts.Count)
                    {
                        weaponParts.Insert(index, particle);
                    }
                }

                else if(action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= 0 && index < weaponParts.Count)
                    {
                        weaponParts.Remove(weaponParts[index]);
                    }
                }

                else if(commandArgs[1] == "Even")
                {                    
                    List<string> evenParts = new List<string>();

                    for (int i = 0; i < weaponParts.Count; i++)
                    {
                        if(i % 2 == 0)
                        {
                            evenParts.Add(weaponParts[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", evenParts));
                }

                else if(commandArgs[1] == "Odd")
                {                   
                    List<string> oddParts = new List<string>();

                    for (int i = 0; i < weaponParts.Count; i++)
                    {
                        if (i % 2 == 1)
                        {
                            oddParts.Add(weaponParts[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", oddParts));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", weaponParts)}!");
        }
    }
}
