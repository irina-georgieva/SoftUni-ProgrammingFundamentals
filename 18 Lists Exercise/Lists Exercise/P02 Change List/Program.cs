using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "end")
            {            
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(commandArgs[1]));
                }
                if (action == "Insert")
                {
                    numbers.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
