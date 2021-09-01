namespace Ch16_2_5_SelectMany2
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
                new User { Name = "Sam", Age = 43 },
                new User { Name = "Tom", Age = 33 }
            };
            
            List<Phone> phones = new List<Phone>()
            {
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple"},
            };

            //var people = from user in users
            //             from phone in phones
            //             select new { Name = user.Name, Phone = phone.Name };

            var people = users.SelectMany(users => phones, (u, p) => new { Name = u.Name, Phone = p.Name });

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Phone}");
            }
        }

    }
    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
