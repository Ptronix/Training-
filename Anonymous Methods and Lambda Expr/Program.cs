using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods_and_Lambda_Expr
{
    delegate void Operattion(int number);

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Operattion op = Double;
        //    op(4);
        //}
        //static void Double(int number)
        //{
        //    Console.WriteLine("{0} x 2 = {1}", number, number * 2);
        //    Console.WriteLine("{0} x 3 = {1}", number, number * 3);
        //    Console.WriteLine("{0} x 4 = {1}", number, number * 4);
        //}


        //BETTER  
        static void Main(string[] args)
        {
            Operattion op = delegate (int number)
            //These are anonymous methods because  No name
            {
                Console.WriteLine("{0} x 2 = {1}", number, number * 2);
                Console.WriteLine("{0} x 3 = {1}", number, number * 3);
                Console.WriteLine("{0} x 4 = {1}", number, number * 4);

            };
            // and call the delegate
            op(2);

        }

    }
}
