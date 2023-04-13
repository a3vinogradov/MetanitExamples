namespace Ch16_2_SelectObjects
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
                new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = from user in users
                                where user.Age > 25
                                select user;

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
