using System;

namespace P03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            
            if (typeGroup == "Students")
            {
                if(day == "Friday")
                {
                    price = 8.45;
                }
                else if(day == "Saturday")
                {
                    price = 9.80;
                }
                else if(day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if(typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if(typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double priceTotal = price * people;

            if(typeGroup == "Students" && people >= 30)
            {
                priceTotal *= 0.85;
            }

            else if (typeGroup == "Business" && people >= 100)
            {
                priceTotal = price * (people-10);
            }

            if (typeGroup == "Regular" && people >= 10 && people <=20)
            {
                priceTotal -= priceTotal * 0.05;
            }

            Console.WriteLine($"Total price: {priceTotal:F2}");
        }
    }
}
