using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch16_6_1_Take_Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            var resTake = numbers.Take(3);
            var resSkip = numbers.Skip(3);
            var resTakeSkip = numbers.Skip(4).Take(3);

            Console.Write("numbers = ");
            PrintArray(numbers);

            Console.Write("numbers.Take(3) = ");
            PrintArray(resTake);

            Console.Write("numbers.Skip(3) = ");
            PrintArray(resSkip);

            Console.Write("numbers.Skip(4).Take(3) = ");
            PrintArray(resTakeSkip);
        }

        static void PrintArray(IEnumerable<int> arr)
        {
            Console.Write("{");
            Console.Write($"{arr.First()}");
            for (int i = 1; i < arr.Count(); i++)
            {
                Console.Write($", {arr.ElementAt(i)}");
            }
            Console.WriteLine("}");
        }
    }

}
