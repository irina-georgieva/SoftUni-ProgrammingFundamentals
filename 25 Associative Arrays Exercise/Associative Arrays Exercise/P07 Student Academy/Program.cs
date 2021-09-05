using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var student in students.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
