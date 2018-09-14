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
       
        static void Main(string[] args)
        {   
            //use action fpr methods without an return param
            Action<int> op = number => { Console.WriteLine("Action: {0} x 2 = {1}", number, number * 2); };
           
            //use func for methods with returnn values
            Func<int, int> Double = x => { return x * 2;};

            Console.WriteLine("Func: " +Double(3));

            op(3);

        }
    }
}
