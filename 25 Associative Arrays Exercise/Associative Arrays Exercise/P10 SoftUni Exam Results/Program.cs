using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while(input !="exam finished")
            {
                string[] inputData = input.Split('-');
                string username = inputData[0];
                string programminLanguage = inputData[1];

                if(programminLanguage == "banned")
                {
                    results.Remove(username);

                    input = Console.ReadLine();
                    continue;
                }
                
                int points = int.Parse(inputData[2]);


                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                }
                else if(results[username] < points)
                {
                    results[username] = points;
                }
                if(!submissions.ContainsKey(programminLanguage))
                {
                    submissions.Add(programminLanguage, 0);
                }

                submissions[programminLanguage]++;

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var (username, points) in results.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username} | {points}");
            }

            Console.WriteLine("Submissions:");
            foreach (var (language, count) in submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
