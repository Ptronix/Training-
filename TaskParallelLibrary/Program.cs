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
            Console.ForegroundColor = ConsoleColor.Green;
            //create task

            var t1 = Task.Factory.StartNew(() => DoSomeStuff(1, 1500) );
            
            var t2 = Task.Factory.StartNew(() => DoSomeStuff(2, 500));
            
            var t3 = Task.Factory.StartNew(() => DoSomeStuff(3, 2000));
            
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        static void DoSomeStuff(int id, int sleepTime)
        {
            Console.WriteLine("task: {0} is beginning",id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);
        }
    }
}
