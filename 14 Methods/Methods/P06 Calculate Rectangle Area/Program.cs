using System;

namespace P06_Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = FindArea(width, height);

            Console.WriteLine(area);
        }

        private static double FindArea(double width, double height)
        {
            return width * height;
        }
    }
}
