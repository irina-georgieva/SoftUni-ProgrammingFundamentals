using System;

namespace P01_National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmplyeeCapacity = int.Parse(Console.ReadLine());
            int secondEmplyeeCapacity = int.Parse(Console.ReadLine());
            int thirdEmplyeeCapacity = int.Parse(Console.ReadLine());
            int allPeople = int.Parse(Console.ReadLine());

            int hourCount = 0;
            int answeredPeoplePerHour = firstEmplyeeCapacity + secondEmplyeeCapacity + thirdEmplyeeCapacity;

            while (allPeople > 0)
            {
                hourCount++;

                if (hourCount % 4 == 0)
                {
                    continue;
                }

                allPeople -= answeredPeoplePerHour;
            }

            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}
