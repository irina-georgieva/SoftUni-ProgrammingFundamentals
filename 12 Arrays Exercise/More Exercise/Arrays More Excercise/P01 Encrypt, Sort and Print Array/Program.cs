using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Threading.Channels;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());            
            int[] sums = new int[count];

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();               
                int sum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    char duplicate = name[j];
                    string currentLatter = name[j].ToString().ToLower();
                    switch (currentLatter)
                    {
                        case "a":
                        case "o":
                        case "u":
                        case "i":
                        case "e":
                            sum += duplicate * name.Length;
                            break;
                        default:
                            sum += duplicate / name.Length;
                            break;
                    }
                }
                sums[i] = sum;
            }
            Array.Sort(sums);
            foreach (var element in sums)
            {
                Console.WriteLine($"{element} ");
            }
        }
    }
}