using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void MyDelegate(string name);

        static void Main(string[] args)
        {
            // no need to instantiate the delegate method in c#
            // MyDelegate dele = new MyDelegate(Greetings);
            MyDelegate dele = GiveMeMyDelegate();
             Test(dele);
            //compiler knows that it should invoked
            //dele.Invoke();

            GiveMeMyDelegate();

            Console.ReadLine();
        }
        static void Test (MyDelegate dele)
        {
            dele("Philipp");
        }

        static void Greetings(string name) { Console.WriteLine("Hey {0} how are you today?",name); }

        static MyDelegate GiveMeMyDelegate()
        {
            return new MyDelegate(Greetings);
        }
    }

}
