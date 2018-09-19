using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintData("philipp", age: 30);
        }
        //named params
        static void PrintData(string firstName, string lastName = null, int age = 0)
        {
            Console.WriteLine("{0} {1} is {2} years old.", firstName, lastName, age);

            Console.ReadLine();

        }

        //static void PrintData(string firstName, string lastName, int age)
        //{
        //    Console.WriteLine("{0} {1} is {2} years old.",firstName,lastName,age);

        //    Console.ReadLine();
        //}

        //static void PrintData(string firstName, string lastName)
        //{
        //    PrintData(firstName, lastName, 0);
        //}

        //static void PrintData(string firstName)
        //{
        //    PrintData(firstName, null, 0);
        //}
    }
}
