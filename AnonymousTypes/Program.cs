using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person{FirstName = "Rainer", LastName = "Unfug", Age = 88 },
                new Person{FirstName = "Philipp", LastName = "Meier", Age = 21},
                new Person{FirstName = "Linda", LastName = "Kallies", Age = 25},
                new Person{FirstName = "Angelo", LastName = "Merte", Age = 56 }
            };

            var result = from p in people
                         where p.LastName == "Merte"
                         //create anonymous type
                         //Type is created within the select statement
                         select new { FName = p.FirstName, LName = p.LastName };

            foreach (var p in result)
            {
                Console.WriteLine(p.FName + " " + p.LName);
            }

            Console.ReadLine();

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

    }
}
