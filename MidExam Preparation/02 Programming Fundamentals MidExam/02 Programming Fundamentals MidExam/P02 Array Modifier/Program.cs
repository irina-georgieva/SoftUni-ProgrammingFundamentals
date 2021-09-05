using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commandArgs = command.Split(" ");
                string action = commandArgs[0];

                if(action == "swap")
                {
                    int indexOne = int.Parse(commandArgs[1]);
                    int indexTwo = int.Parse(commandArgs[2]);

                    int currentNumber = elements[indexOne];
                    elements[indexOne] = elements[indexTwo];
                    elements[indexTwo] = currentNumber;

                }
                else if(action == "multiply")
                {
                    int indexOne = int.Parse(commandArgs[1]);
                    int indexTwo = int.Parse(commandArgs[2]);

                    int newNumber = elements[indexOne] * elements[indexTwo];
                    elements[indexOne] = newNumber;
                }
                else if(action == "decrease")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        elements[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
