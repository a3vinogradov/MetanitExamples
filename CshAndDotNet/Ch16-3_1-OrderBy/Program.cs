namespace Ch16_3_1_OrderBy
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };

            var orderedNumbers = numbers.OrderBy(i=>i);
            //var orderedNumbers = from i in numbers
            //                     orderby i
            //                     select i;

            foreach (int i in orderedNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
