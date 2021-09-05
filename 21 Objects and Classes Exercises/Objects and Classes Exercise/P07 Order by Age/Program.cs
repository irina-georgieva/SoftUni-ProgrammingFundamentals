using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Order_by_Age
{
    class Student
    {

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] splitted = input.Split(" ");
                string name = splitted[0];
                string id = splitted[1];
                int age = int.Parse(splitted[2]);

                Student student = new Student();
                student.Name = name;
                student.ID = id;
                student.Age = age;

                students.Add(student);

                input = Console.ReadLine();
            }

            students = students.OrderBy(s => s.Age).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }

        }
    }
}
