using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Name = "Philipp", Age = 30 };

            var p2 = new Person { Name = "Laura", Age = 29 };

            p.SayHello(p2);
        }
    }
    
    public static class Extensions
    {
        public static void SayHello(this Person person, Person person2)
        {
            Console.WriteLine("{0} says \"hello\" to {1}.",person.Name, person2.Name);

            Console.ReadLine();
        }
    }
    
}
