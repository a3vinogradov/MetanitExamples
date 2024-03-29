﻿namespace Ch16_2_Where
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            //IEnumerable<int> evens = numbers.Where(t => t % 2 == 0 && t > 10);
            IEnumerable<int> evens = from i in numbers
                                     where i % 2 == 0 && i > 10
                                     select i;

            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }
        }
    }
}
