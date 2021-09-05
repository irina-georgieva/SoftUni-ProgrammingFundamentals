using System;

namespace P09_Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double costsLight = lightsabers * Math.Ceiling(students * 1.1);
            double costRobes = robes * students;
            double costBelts = belts * (students - (students / 6));


            double costsAll = lightsabers * Math.Ceiling(students * 1.1) + 
                              belts * (students - (students / 6)) + 
                              robes * students;

            if(money >= costsAll)
            {
                Console.WriteLine($"The money is enough - it would cost {costsAll:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {costsAll - money:F2}lv more.");
            }
        }
    }
}
