using System;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];
            int sumPeople = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;                
            }

            for (int i = 0; i < train.Length; i++)
            {
                sumPeople += train[i];

                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPeople);

        }
    }
}
