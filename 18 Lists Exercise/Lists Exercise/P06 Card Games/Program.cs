using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Card_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                   
            List<int> secondPlayerDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
           

            while (firstPlayerDeck.Count != 0 && secondPlayerDeck.Count != 0)
            {

                if (firstPlayerDeck[0] > secondPlayerDeck[0])
                {
                    firstPlayerDeck.Add(firstPlayerDeck[0]);
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);

                    firstPlayerDeck.Add(secondPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                }
                else if(secondPlayerDeck[0] > firstPlayerDeck[0])
                {
                    secondPlayerDeck.Add(secondPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);

                    secondPlayerDeck.Add(firstPlayerDeck[0]);
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);
                }
                else if (firstPlayerDeck[0] == secondPlayerDeck[0])
                {
                    firstPlayerDeck.Remove(firstPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                }
            }

            if (firstPlayerDeck.Count > 0)
            {
                int resultSum = firstPlayerDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {resultSum}");
            }
            else if (secondPlayerDeck.Count > 0)
            {
                int resultSum = secondPlayerDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {resultSum}");
            }
        }
    }
}
