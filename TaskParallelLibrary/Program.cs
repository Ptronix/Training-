using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<long> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 33, 5, 11, 66, 44, 75 };

            Console.ForegroundColor = ConsoleColor.Green;
            Parallel.For(0, 9223372036854775807, (i) => Console.Write(i));
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        static void DoSomeStuff(int id, int sleepTime)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task: {0} is beginning ",id);
            Thread.Sleep(sleepTime);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("task {0} has completed ", id);
        }

        static void DoMoreStuff(int id, int sleepTime)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task: {0} is beginning more stuff ", id);
            Thread.Sleep(sleepTime);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task {0} has completed more stuff", id);
        }
    }
}
