using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int indexCupidon = 0;

            while (command != "Love!")
            {
                string[] commandArgs = command.Split(" ");
                int jumpLength = int.Parse(commandArgs[1]);

                indexCupidon += jumpLength;

                if(indexCupidon > houses.Count-1)
                {
                    indexCupidon = 0;
                }

                if (houses[indexCupidon] == 0)
                {
                    Console.WriteLine($"Place {indexCupidon} already had Valentine's day.");
                    command = Console.ReadLine();
                    continue;
                }

                houses[indexCupidon] -= 2;

                if(houses[indexCupidon] == 0)
                {
                    Console.WriteLine($"Place {indexCupidon} has Valentine's day.");                    
                }               

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {indexCupidon}.");

            bool isValentine = false;
            int countHouses = 0;
            for (int i = 0; i < houses.Count; i++)
            {
                if(houses[i] == 0)
                {
                    isValentine = true;
                }
                else
                {
                    isValentine = false;
                    break;
                }
            }

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] != 0)
                {
                    countHouses++;
                }               
            }

            if (isValentine)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countHouses} places.");
            }
        }
    }
}
