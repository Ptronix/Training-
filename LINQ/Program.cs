using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person {FirstName = "Flip", LastName= "Smith", Age = 30 },
                new Person {FirstName = "John", LastName= "Unfug", Age = 26 },
                new Person {FirstName = "Rainer", LastName= "Unfug", Age = 24 },
                new Person {FirstName = "Steve", LastName= "Stevenson", Age = 38 },
                new Person {FirstName = "Mila", LastName= "Smith", Age = 18 },
            };

            var sample = "I enjoy learning C#. Become a good programmer is hard work and you have to read a lot of.";

            var result = from p in people
                         where p.Age < 27
                         orderby p.LastName
                         group p by p.LastName;
                         
            
                         
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + "-" +item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}",p.LastName,p.FirstName);
                }
            }
            Console.ReadLine();
        }

        public class Person 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
