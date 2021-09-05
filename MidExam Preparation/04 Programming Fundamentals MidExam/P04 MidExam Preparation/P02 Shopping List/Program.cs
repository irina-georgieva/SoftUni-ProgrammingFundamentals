using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {  
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                string item = commandArgs[1];

                if (command == "Urgent")
                {
                    if(!shoppingList.Contains(item))
                    { 
                        shoppingList.Insert(0, item);
                    }
                }
                else if(command == "Unnecessary")
                {
                    if(shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }                 
                }
                else if(command == "Correct")
                {
                    string newItem = commandArgs[2];

                    if(shoppingList.Contains(item))
                    {
                        int oldItemIndex = shoppingList.FindIndex(s => s == item);
                        shoppingList[oldItemIndex] = newItem;
                    }
                }
                else if(command == "Rearrange")
                {
                    if(shoppingList.Contains(item))
                    {
                        string currentItem = item;
                        shoppingList.Remove(item);
                        shoppingList.Add(currentItem);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));

        }
    }
}
