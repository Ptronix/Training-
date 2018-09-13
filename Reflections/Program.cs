using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            //stored under C:\\windows\assembly
            //Public / Shared assembly is stored in GAC Global Assembly Cache

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine("Assembly Type: {0}", type);

                // returns an array of props from current assembly
                var properties = type.GetProperties();
                var fields = type.GetFields();

                foreach (var property in properties)
                {
                    Console.WriteLine("Propertie: {0}", properties);
                }
                Console.WriteLine();

                foreach (var field in fields)
                {
                    Console.WriteLine("Field: {0}",field);
                }
                
            }

            Console.ReadLine();
        }
    }
    public class AnyClass
    {
        //that is a Field
        public int Age;
        //compiler creates automatically creates a private member of that type

        //that is a propertie
        public bool IsAdult { get; set; }

    }
}
