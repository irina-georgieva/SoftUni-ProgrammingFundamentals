using System;
using System.Collections.Generic;

namespace P05_Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string members)
        {
            Members = new List<string>();
            TeamName = teamName;
            Members.Add(members);
        }

        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numTeams = int.Parse(Console.ReadLine());
            List<Team> createdTeams = new List<Team>();
            
            for (int i = 0; i < numTeams; i++)
            {
                string[] teams = Console.ReadLine().Split("-");
                string name = teams[0];
                string user = teams[1];

                bool teamExists = false;

                foreach (var newTeam in createdTeams)
                {
                    if (newTeam.TeamName == name)
                    {
                        teamExists = true;
                        Console.WriteLine($"Team {name} was already created!");
                        break;
                    }
                    if (newTeam.Members[0] == user)
                    {
                        teamExists = true;
                        Console.WriteLine($"{user} cannot create another team!");
                        break;
                    }
                }

                if (!teamExists)
                {
                    Console.WriteLine($"Team {name} has been created by {user}!");
                }
            }

            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] teamMember = command.Split("->");
                string member = teamMember[0];
                string team = teamMember[1];

                bool memberCanJoin = false;
                foreach (var newTeam in createdTeams)
                {
                    if (newTeam.TeamName == team)
                    {
                        memberCanJoin = true;
                    }
                    else
                    {
                        Console.WriteLine($"Team {team} does not exist!");
                        memberCanJoin = false;
                    }
                    if (newTeam.Members.Contains(member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {team}!");
                        memberCanJoin = false;
                    }
                    else
                    {
                        memberCanJoin = true;
                    }
                }

                if(memberCanJoin)
                {
                    int teamIndex = createdTeams.FindIndex(t => t.TeamName == team);
                    createdTeams[teamIndex].Members.Add(member);
                }

                command = Console.ReadLine();
            }

            foreach (var team in createdTeams)
            {
                if(team.Members.Count > 1)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine($"- {team.Members[0]}");

                    foreach (var member in team.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }

            foreach (var team in createdTeams)
            {
                if(team.Members.Count == 1)
                {
                    Console.WriteLine("Teams to disband:");
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }
}
