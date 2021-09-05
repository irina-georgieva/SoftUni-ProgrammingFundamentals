using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while(command != "end")
            {
                string[] commandArgs = command.Split(" ");

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string homeTown = commandArgs[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = students.Where(s => s.HomeTown == city).ToList();

            foreach (var misho in filteredStudents)
            {
                Console.WriteLine($"{misho.FirstName} {misho.LastName} is {misho.Age} years old.");
            }
        }
    }
}
