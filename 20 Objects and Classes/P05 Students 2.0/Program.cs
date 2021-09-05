using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Students_2._0
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

            List<Student> studentsList = new List<Student>();

            while (command != "end")
            {
                string[] commandArgs = command.Split(" ");

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string homeTown = commandArgs[3];

                Student studentUni = studentsList.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (studentUni == null)
                {
                    studentsList.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    studentUni.FirstName = firstName;
                    studentUni.LastName = lastName;
                    studentUni.Age = age;
                    studentUni.HomeTown = homeTown;                    
                }

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = studentsList.Where(s => s.HomeTown == city).ToList();

            foreach (var misho in filteredStudents)
            {
                Console.WriteLine($"{misho.FirstName} {misho.LastName} is {misho.Age} years old.");
            }
        }
    }
}

