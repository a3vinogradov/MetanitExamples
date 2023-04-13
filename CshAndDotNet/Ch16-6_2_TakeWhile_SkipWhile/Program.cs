using System;
using System.Linq;

namespace Ch16_6_2_TakeWhile_SkipWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            Console.WriteLine("All teams:");
            foreach (var t in teams)
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine("Start with Б: ");
            foreach (var t in teams.TakeWhile(x => x.StartsWith("Б")))
            Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine("Start with not Б: ");
            foreach (var t in teams.SkipWhile(x => x.StartsWith("Б")))
                Console.WriteLine(t);
        }
    }
}
