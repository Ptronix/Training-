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

            var t1 = new Task(() => DoSomeStuff(1, 1500) );
            t1.Start();
            var t2 = new Task(() => DoSomeStuff(2, 500));
            t2.Start();
            var t3 = new Task(() => DoSomeStuff(3, 2000));
            t3.Start();
           

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
