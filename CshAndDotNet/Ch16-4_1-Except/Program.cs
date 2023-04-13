using System;
using System.Linq;

namespace Ch16_4_1_Except
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };

            Console.WriteLine("Исходные данные ");
            
            Console.WriteLine("  Программное обеспечение: ");
            foreach (string s in soft)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("  Аппаратное обеспечение: ");
            foreach (string s in hard)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            var result = soft.Except(hard);

            Console.WriteLine("  Разность последовательностей");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            result = soft.Intersect(hard);

            Console.WriteLine("  Пересечение последовательностей");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            result = soft.Union(hard);

            Console.WriteLine("  Объединение последовательностей");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            result = soft.Concat(hard);

            Console.WriteLine("  Соединение последовательностей");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            result = soft.Concat(hard).Distinct();
            Console.WriteLine("  Удаление дубликатов");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
