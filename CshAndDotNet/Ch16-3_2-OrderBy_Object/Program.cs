namespace Ch16_3_2_OrderBy_Object
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

            //var sortedUsers = from u in users
            //                  orderby u.Name
            //                  select u;

            var sortedUsers = users.OrderBy(u => u.Name);

            Console.WriteLine("Пример сортировки по возрастанию");
            foreach (User u in sortedUsers)
            {
                Console.WriteLine(u.Name);
            }
            Console.WriteLine();

            //sortedUsers = from u in users
            //              orderby u.Name descending
            //              select u;

            sortedUsers = users.OrderByDescending(u => u.Name);
            Console.WriteLine("Пример сортировки по убыванию");
            foreach (User u in sortedUsers)
            {
                Console.WriteLine(u.Name);
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
