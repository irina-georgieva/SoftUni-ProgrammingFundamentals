using System;
using System.Collections.Generic;

namespace P05_SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> regUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string user = input[1];

                if(command == "register")
                {
                    string plate = input[2];

                    if (regUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        regUsers.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                }
                else if(command == "unregister")
                {
                    if (!regUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        regUsers.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }

            foreach (var user in regUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
