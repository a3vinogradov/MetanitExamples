namespace Ch16_5_2_Sum_Min_Max_Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            List<User> users = new List<User>()
                                    {
                                        new User { Name = "Tom", Age = 23 },
                                        new User { Name = "Sam", Age = 43 },
                                        new User { Name = "Bill", Age = 35 }
                                    };

            int sum1 = numbers.Sum();
            decimal sum2 = users.Sum(n => n.Age);

            int min1 = numbers.Min();
            int min2 = users.Min(n => n.Age); // минимальный возраст

            int max1 = numbers.Max();
            int max2 = users.Max(n => n.Age); // максимальный возраст

            double avr1 = numbers.Average();
            double avr2 = users.Average(n => n.Age); //средний возраст

            Console.Write("numbers = {");
            Console.Write($"{numbers[0]}");
            for (int i = 1; i < numbers.Count(); i++)
            {
                Console.Write($", {numbers[i]}");
            }
            Console.WriteLine("}");

            Console.WriteLine("users = {");
            for (int i = 0; i < users.Count(); i++)
            {
                Console.Write($"  {users[i]}");
                Console.WriteLine(i == users.Count() - 1 ? "" : ",");
            }
            Console.WriteLine("}");


            Console.WriteLine($"numbers.Sum() = {sum1}");
            Console.WriteLine($"users.Sum(n => n.Age) = {sum2}");
            Console.WriteLine($"numbers.Min() = {min1}");
            Console.WriteLine($"users.Min(n => n.Age) = {min2}");
            Console.WriteLine($"numbers.Max() = {max1}");
            Console.WriteLine($"users.Max(n => n.Age) = {max2}");
            Console.WriteLine($"numbers.Average() = {avr1}");
            Console.WriteLine($"users.Average(n => n.Age) = {avr2}");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "{" + $"Name = {Name}, Age = {Age}" + "}";
        }

    }
}
