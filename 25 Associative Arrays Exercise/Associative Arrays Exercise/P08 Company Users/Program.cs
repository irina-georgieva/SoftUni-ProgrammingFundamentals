using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while(input != "End")
            {
                string[] inputArgs = input.Split(" -> ");
                string name = inputArgs[0];
                string id = inputArgs[1];

                if(!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string>());
                    companies[name].Add(id);
                }
                else if(companies.ContainsKey(name) && !companies[name].Contains(id))
                {
                    companies[name].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var item in companies.OrderBy(x=> x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var name in item.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
