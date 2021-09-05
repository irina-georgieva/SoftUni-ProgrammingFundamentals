using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();            
            bool end = false;

            while(!end)
            {
                string command = Console.ReadLine();

                if(command == "course start")
                {
                    end = true;
                    continue;
                }

                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];

                switch (action)
                {
                    case "Add":
                        if(!lessons.Contains(commandArgs[1]))
                        {
                            lessons.Add(commandArgs[1]);
                        }                       
                        break;

                    case "Insert":
                        if(!lessons.Contains(commandArgs[1]))
                        {
                            lessons.Insert(int.Parse(commandArgs[2]), commandArgs[1]);
                        }                      
                        break;

                    case "Remove":                        

                        if(lessons.Contains(commandArgs[1]))
                        {
                            lessons.Remove(commandArgs[1]);
                        }
                        if(lessons.Contains(commandArgs[1]) && lessons.Contains(commandArgs[1] + "-Exercise"))
                        {
                            lessons.Remove(commandArgs[1] + "-Exercise");
                        }
                        break;

                    case "Swap":
                        string firstLesson = commandArgs[1];
                        string secondLesson = commandArgs[2];

                        if (lessons.Contains(firstLesson) && lessons.Contains(secondLesson))
                        {
                            int firstIndex = lessons.IndexOf(firstLesson);
                            int secondIndex = lessons.IndexOf(secondLesson);

                            string tmp = lessons[firstIndex];
                            lessons[firstIndex] = lessons[secondIndex];
                            lessons[secondIndex] = tmp;
                            
                            if (firstIndex > 0 && firstIndex < lessons.Count - 1)
                            {
                                if (lessons[firstIndex + 1].Contains("Exercise"))
                                {
                                    lessons.Insert(firstIndex + 1, lessons[firstIndex + 1]);
                                    lessons.RemoveAt(firstIndex + 1);
                                }
                            }

                            if (secondIndex < lessons.Count - 1 && secondIndex > 0)
                            {
                                if (lessons[secondIndex + 1].Contains("Exercise"))
                                {
                                    lessons.Insert(firstIndex + 1, lessons[secondIndex + 1]);
                                    lessons.RemoveAt(secondIndex + 2);
                                }
                            }
                        }
                        break;

                    case "Exercise":
                        string lessonTitle = commandArgs[1];

                        if (lessons.Contains(lessonTitle) && !lessons.Contains(lessonTitle + "Exercise"))
                        {
                            int indexLesson = lessons.IndexOf(lessonTitle);
                            lessons.Insert(indexLesson + 1, lessonTitle + "-Exercise");
                        }
                        else if (!lessons.Contains(lessonTitle) && !lessons.Contains(lessonTitle + "Exercise"))
                        {                            
                            string newLesson = lessonTitle + "-Exercise";
                            lessons.Add(lessonTitle);
                            lessons.Add(newLesson);
                        }
                        break;
                }
            }

            int count = 1;

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{count}.{lessons[i]}");
                count++;
            }
        }
    }
}
