using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Operation(int number);

        static void Main(string[] args)
        {
            //initialized the delegate
            Operation op = Double;
            //past it into the Method
            ExcecuteOperation(2, op);

            //change the delegator operation to Triple()
            op = Triple;
            ExcecuteOperation(5, op);

        }
        static void Double(int number)
        {
            Console.WriteLine("{0} x 2 = {1}", number, number * 2);
        }

        static void Triple(int number)
        {
            Console.WriteLine("{0} x 3 = {1}",number,number*3);
        }

        static void ExcecuteOperation(int number, Operation operation)
        {
            operation(number);
        }

    }

}
