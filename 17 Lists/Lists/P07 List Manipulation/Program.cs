using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_List_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            bool flag = false;

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if(action == "Add")
                {
                    numbers.Add(int.Parse(commandArgs[1]));
                    flag = true;
                }
                else if(action == "Remove")
                {
                    numbers.Remove(int.Parse(commandArgs[1]));
                    flag = true;
                }
                else if(action == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                    flag = true;
                }
                else if(action == "Insert")
                {
                    numbers.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                    flag = true;
                }

                if (action == "Contains")
                {
                    int element = int.Parse(commandArgs[1]);

                    if (numbers.Contains(element))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNumbers.Add(numbers[i]);
                        }
                    }
                
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();                    

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            oddNumbers.Add(numbers[i]);
                        }                 
                    }

                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if(action == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else if(action == "Filter")
                {                   
                    string condition = commandArgs[1];
                    int number = int.Parse(commandArgs[2]);
                    List<int> filterPrint = new List<int>();
                  
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(condition == "<")
                        {
                            if(numbers[i] < number)
                            {
                                filterPrint.Add(numbers[i]);
                            }
                        }
                        else if(condition == ">")
                        {
                            if (numbers[i] > number)
                            {
                                filterPrint.Add(numbers[i]);
                            }
                        }
                        if(condition == ">=")
                        {
                            if (numbers[i] >= number)
                            {
                                filterPrint.Add(numbers[i]);
                            }
                        }
                        if(condition == "<=")
                        {
                            if (numbers[i] <= number)
                            {
                                filterPrint.Add(numbers[i]);                            }
                        }                       
                    }

                    Console.WriteLine(string.Join(" ", filterPrint));
                }

                command = Console.ReadLine();
            }

            if(flag)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
