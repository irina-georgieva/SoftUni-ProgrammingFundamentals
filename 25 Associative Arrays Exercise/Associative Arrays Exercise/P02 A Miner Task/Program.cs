using System;
using System.Collections.Generic;

namespace P02_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            string input = Console.ReadLine();
            bool isOdd = true;
            string currentItem = string.Empty;

            while(input != "stop")
            {
                if(isOdd)
                {
                    if(!items.ContainsKey(input))
                    {
                        items.Add(input, 0);
                    }

                    currentItem = input;

                    isOdd = false;
                }
                else
                {
                    int value = int.Parse(input);
                    items[currentItem] += value;
                    isOdd = true;
                }

                input = Console.ReadLine();
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{ item.Key} -> { item.Value}");
            }
        }
    }
}
