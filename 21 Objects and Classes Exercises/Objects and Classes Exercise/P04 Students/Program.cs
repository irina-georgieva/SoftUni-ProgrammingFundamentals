using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Students
{
    class Student
    {
        public Student(string firstName, string secondName, float grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public float Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                
                string[] studentsData = input.Split(" ");
                string firstName = studentsData[0];
                string secondName = studentsData[1];
                float grade = float.Parse(studentsData[2]);

                students.Add(new Student(firstName, secondName, grade));
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:F2}");
            }
        }
    }
}
