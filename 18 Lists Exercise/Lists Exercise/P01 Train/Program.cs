using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] commandArg = command.Split();

                if(commandArg[0] == "Add")
                {
                    int passengers = int.Parse(commandArg[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(commandArg[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + passengers <= maxPassengers)
                        {
                            wagons[i] += passengers;
                            break;
                        }

                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
