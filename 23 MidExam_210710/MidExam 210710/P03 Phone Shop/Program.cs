using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> storagePhones = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] commandArgs = command.Split(" - ");
                string action = commandArgs[0];

                if(action == "Add")
                {
                    string phone = commandArgs[1];

                    if(!storagePhones.Contains(phone))
                    {
                        storagePhones.Add(phone);
                    }
                }

                else if(action == "Remove")
                {
                    string phone = commandArgs[1];

                    if(storagePhones.Contains(phone))
                    {
                        storagePhones.Remove(phone);
                    }
                }

                else if(action == "Bonus phone")
                {
                    string[] phones = commandArgs[1].Split(":");
                    string oldPhone = phones[0];
                    string newPhone = phones[1];

                    if(storagePhones.Contains(oldPhone))
                    {
                        int indexPhone = storagePhones.FindIndex(s => s == oldPhone);

                        storagePhones.Insert(indexPhone + 1, newPhone);

                    }
                }

                else if(action == "Last")
                {
                    string phone = commandArgs[1];

                    if(storagePhones.Contains(phone))
                    {
                        string currentPhone = phone;
                        storagePhones.Remove(phone);
                        storagePhones.Add(currentPhone);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", storagePhones));
        }
    }
}
