namespace Ch16_2_4_Select
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Sam", Age = 43 });
            users.Add(new User { Name = "Tom", Age = 33 });

            //var names = from user in users select user.Name;
            var names = users.Select(user => user.Name);

            Console.WriteLine("пример проекции в строку");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            var items = users.Select(user => new
                                            {
                                                FirstName = user.Name,
                                                DateOfBirth = DateTime.Now.Year - user.Age
                                            });
            //var items = from u in users
            //            select new
            //            {
            //                FirstName = u.Name,
            //                DateOfBirth = DateTime.Now.Year - u.Age
            //            };

            Console.WriteLine("пример проекции в анонимный тип");
            foreach (var n in items)
            {
                Console.WriteLine($"{n.FirstName} - {n.DateOfBirth}");
            }
            Console.WriteLine();

            var people = from u in users
                         let name = "Mr. " + u.Name
                         select new
                         {
                             Name = name,
                             Age = u.Age
                         };
            // Аналога в методах расширения нет.
            Console.WriteLine("пример использования let");
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.WriteLine();

        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
