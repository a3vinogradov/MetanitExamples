namespace Ch16_5_1_Aggregate_Count
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int query = numbers.Aggregate((x, y) => x - y);
            int countQry = numbers.Count();

            int countEvenQry1 = (from i in numbers where i % 2 == 0 select i).Count();

            int countEvenQry2 = numbers.Count(i => i % 2 == 0);

            Console.Write("numbers = {");
            Console.Write($"{numbers[0]}");
            for (int i=1; i<numbers.Count();i++)
            {
                Console.Write($", {numbers[i]}");
            }
            Console.WriteLine("}");


            Console.WriteLine($"numbers.Aggregate((x, y) => x - y) = {query}");
            Console.WriteLine($"numbers.Count() = {countQry}");

            Console.WriteLine($"Count even numbers is {countEvenQry1} ");
            Console.WriteLine($"Count even numbers (another way) is {countEvenQry2} ");
        }
    }
}
