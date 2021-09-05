using System;

namespace P01_Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());          
            string distance = Console.ReadLine();
            int countWin = 0;
            bool noEnergy = false;

            while (distance != "End of battle")
            {
                if(energy < int.Parse(distance))
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWin} won battles and {energy} energy");
                    noEnergy = true;
                    return;
                }
                
                energy -= int.Parse(distance);

                if(energy >= 0)
                {
                    countWin++;
                    if (countWin % 3 == 0)
                    {
                        energy += countWin;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWin} won battles and {energy} energy");
                    noEnergy = true;
                    return;
                }                

                distance = Console.ReadLine();
            }

            if (!noEnergy)
            {
                Console.WriteLine($"Won battles: {countWin}. Energy left: {energy}");
            }
        }
    }
}
