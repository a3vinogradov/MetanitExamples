namespace Ch16_3_3_OrderBy_MultiSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {


        static void Main(string[] args)
        {

            List<User> users = new List<User>()
            {
                new User { Name = "Tom", Age = 33 },
                new User { Name = "Bob", Age = 30 },
                new User { Name = "Tom", Age = 21 },
                new User { Name = "Sam", Age = 43 }
            };

            //var sortedUsers = from user in users
            //             orderby user.Name, user.Age
            //             select user;
            var sortedUsers = users.OrderBy(u => u.Name).ThenBy(u => u.Age);

            Console.WriteLine("Пример сортировки по имени и возрасту");
            foreach (User u in sortedUsers)
            {
                Console.WriteLine($"{u.Name} - {u.Age}");
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
