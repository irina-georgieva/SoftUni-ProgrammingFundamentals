using System;

namespace P01_Problem_1_Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersNumber = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < ordersNumber; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceCoffee = (days * capsulesCount) * priceCapsule;

                Console.WriteLine($"The price for the coffee is: ${priceCoffee:F2}");

                totalPrice += priceCoffee;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
