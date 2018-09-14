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
        public string Teststring { get; set; }

        //BETTER  
        static void Main(string[] args)
        {
            Program program = new Program();

            // Lambda Expression
            // input params in brackets if multiple params output params on right side
            Operattion op =  number => { Console.WriteLine("{0} x 2 = {1}", number, number * 2);  };
            //These are anonymous methods because  No name


            op(2);
        }

    }
}
