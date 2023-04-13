namespace Ch16_2_3_SelectMany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий", "французский" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = from user in users
                                from lang in user.Languages
                                where user.Age < 28
                                where lang == "английский"
                                select user;

            var selectedUsers2 = users.SelectMany(u => u.Languages, (u, l) => new { User = u, Lang = l })
                                      .Where(u => u.Lang == "английский" && u.User.Age < 28)
                                      .Select(u => u.User);


            foreach (User user in selectedUsers)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }
            Console.WriteLine("");

            foreach (User user in selectedUsers)
            {
                Console.WriteLine($"{user.Name} - {user.Age}");
            }

        }
    }

    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Languages { get; set; }

        public User()
        {
            Languages = new List<string>();
        }
    }
}
