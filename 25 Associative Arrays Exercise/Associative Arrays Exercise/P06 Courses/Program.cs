using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> regCourses = new Dictionary<string, List<string>>();

            while(input != "end")
            {
                string[] inputArgs = input.Split(" : ");
                string course = inputArgs[0];
                string user = inputArgs[1];

                if(!regCourses.ContainsKey(course))
                {
                    regCourses.Add(course, new List<string>());
                    regCourses[course].Add(user);
                }
                else
                {
                    regCourses[course].Add(user);
                }

                input = Console.ReadLine();
            }

            foreach (var course in regCourses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var user in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
