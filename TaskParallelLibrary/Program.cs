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
            //create task and start the DoMoreStuff Task when prev task is finsish
            //Chaining of Tasks
            var t1 = Task.Factory.StartNew(() => DoSomeStuff(1, 1500)).ContinueWith((prevtask) => DoMoreStuff(1, 100));
            
            var t2 = Task.Factory.StartNew(() => DoSomeStuff(2, 3000)).ContinueWith((prevtask) => DoMoreStuff(2, 100));

            var t3 = Task.Factory.StartNew(() => DoSomeStuff(3, 1000)).ContinueWith((prevtask) => DoMoreStuff(3, 100));

            var taskList = new List<Task> { t1, t2, t3 };
            Task.WaitAll(taskList.ToArray());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        static void DoSomeStuff(int id, int sleepTime)
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
