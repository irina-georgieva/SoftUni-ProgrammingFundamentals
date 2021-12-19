using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "EndDay")
            {
                string[] inputInfo = input.Split(": ");
                string[] inputZoo = inputInfo[1].Split("-");
                string animalName = inputZoo[0];
                int food = int.Parse(inputZoo[1]);

                if (input.Contains("Add"))
                {
                    string area = inputZoo[2];

                    if (animals.Keys.Contains(animalName))
                    {
                        animals[animalName] += food;
                    }
                    else
                    {
                        animals.Add(animalName, food);
                    }

                    if (!areaAnimals.ContainsKey(area))
                    {
                        areaAnimals.Add(area, new List<string> { animalName });
                    }
                    else
                    {
                        if (!areaAnimals[area].Contains(animalName))
                        {
                            areaAnimals[area].Add(animalName);
                        }
                    }
                }

                if (input.Contains("Feed"))
                {
                    if (animals.Keys.Contains(animalName))
                    {
                        animals[animalName] -= food;
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (animals[animalName] <= 0)
                    {
                        string keyToRemove = string.Empty;

                        foreach (var kvp in areaAnimals)
                        {
                            if (kvp.Value.Contains(animalName))
                            {
                                kvp.Value.Remove(animalName);
                                if (kvp.Value.Count == 0)
                                {
                                    keyToRemove = kvp.Key;
                                }
                            }
                        }

                        if (keyToRemove != string.Empty)
                        {
                            areaAnimals.Remove(keyToRemove);
                        }

                        animals.Remove(animalName);
                        Console.WriteLine($"{animalName} was successfully fed");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Animals:");

            foreach (var a in animals.
                OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{a.Key} -> {a.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var area in areaAnimals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{area.Key}: {area.Value.Count}");
            }
        }
           
    }
}
