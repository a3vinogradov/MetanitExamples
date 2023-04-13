namespace Ch16_1_easy_linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = new List<string>();
            foreach (string s in teams)
            {
                if (s.ToUpper().StartsWith("Б"))
                {
                    selectedTeams.Add(s);
                }
            }

            PrintList("NonLinq select", selectedTeams);

            var linqSelectedTeams = from t in teams
                                    where t.ToUpper().StartsWith("Б")
                                    orderby t
                                    select t;

            PrintList("Linq select", linqSelectedTeams);
            
            var linqExSelectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            PrintList("Linq extension select", linqSelectedTeams);

        }
        
        static void PrintList(string header, IEnumerable<string> list)
        {
            Console.WriteLine(header);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
