using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] field = new int[sizeOfField];

            int[] bugsInField = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < bugsInField.Length; i++)
            {
                field[bugsInField[i]] = 1;
            }

            string rowOfCommands = Console.ReadLine();

            int bugIndexNew = 0;


            while (rowOfCommands != "end")
            {
                string[] commands = rowOfCommands.Split(" ").ToArray();

                int bugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int steps = int.Parse(commands[2]);

                field[bugIndex] = 0;

                while (field[bugIndexNew] == 0)
                {
                    if (direction == "right")
                    {
                        bugIndexNew = bugIndex + steps;
                    }
                    else if (direction == "left")
                    {
                        bugIndexNew = bugIndex - steps;
                    }

                    if (bugIndexNew >= 0 && bugIndexNew <= field.Length-1)
                    {
                        if (field[bugIndexNew] == 0)
                        {
                            field[bugIndexNew] = 1;
                        }

                        else if (field[bugIndexNew] == 1)
                        {
                            int busyPosition = bugIndexNew;
                            field[busyPosition] = 1;
                            bugIndex = bugIndexNew;
                            continue;
                        }
                    }
                    else
                    {
                        break;                        
                    }
                }

                rowOfCommands = Console.ReadLine();
            }

            for (int i = 0; i < field.Length; i++)
            {
                Console.Write(field[i] + " ");
            }
        }
    }
}