using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;

            Regex regex = new Regex(@"^[U][$](?<username>[A-Z][a-z]{2,})[U][$].*?[P][@][$](?<password>[A-Za-z]{5,}[A-Za-z0-9]*?\d)[P][@][$]$");
            string pattern = regex.ToString();

            for (int i = 0; i < input; i++)
            {
                string registration = Console.ReadLine();

                Match matches = Regex.Match(registration, pattern);
            
                if(matches.Success)
                {
                    Console.WriteLine("Registration was successful");
                  
                    Console.WriteLine($"Username: {matches.Groups["username"]}, Password: {matches.Groups["password"]}");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
