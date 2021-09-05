using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int sumRemovedValues = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int lastElement = pokemons[pokemons.Count - 1];
                    int removedValue = pokemons[0];
                    sumRemovedValues += pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, lastElement);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedValue)
                        {
                            pokemons[i] += removedValue;
                        }

                        else if (pokemons[i] > removedValue)
                        {
                            pokemons[i] -= removedValue;
                        }
                    }                   

                    continue;
                }

                if(index > pokemons.Count - 1)
                {
                    int firstElement = pokemons[0];
                    int removedValue = pokemons[pokemons.Count - 1];
                    sumRemovedValues += pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(firstElement);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removedValue)
                        {
                            pokemons[i] += removedValue;
                        }

                        else if (pokemons[i] > removedValue)
                        {
                            pokemons[i] -= removedValue;
                        }
                    }   

                    continue;
                }

                int toBeRemovedValue = pokemons[index];

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= toBeRemovedValue)
                    {
                        pokemons[i] += toBeRemovedValue;
                    }
                    
                    else if(pokemons[i] > toBeRemovedValue)
                    {
                        pokemons[i] -= toBeRemovedValue;
                    }
                }

                sumRemovedValues += toBeRemovedValue;
                pokemons.RemoveAt(index);
               
            }

            Console.WriteLine(sumRemovedValues);
        }
    }
}
