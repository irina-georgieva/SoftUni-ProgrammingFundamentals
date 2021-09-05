using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Shoot_for_the_win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int countShots = 0;

            while(command != "End")
            {
                int indexShot = int.Parse(command);

                if (indexShot < 0 || indexShot > targets.Count-1 || targets[indexShot] == -1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                int curretTarget = targets[indexShot];
                for (int i = 0; i < targets.Count; i++)
                {                
                    if(targets[i] != -1 && targets[i] > curretTarget)
                    {
                        targets[i] -= curretTarget;
                    }
                    else if(targets[i] != -1 && targets[i] <= curretTarget)
                    {
                        targets[i] += curretTarget;
                    }
                }
                targets[indexShot] = -1;
                countShots++;

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countShots} -> {string.Join(" ", targets)}");
        }
    }
}
