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
            var source = new CancellationTokenSource();

            try
            {
                var t1 = Task.Factory.StartNew(() => DoSomeStuff(1, 1000,source.Token )).ContinueWith((prevTask) => DoMoreStuff(1, 500,source.Token));
                source.Cancel();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.GetType());               
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
        static void DoSomeStuff(int id, int sleepTime,CancellationToken cancelToken )
        {
            if (cancelToken.IsCancellationRequested)
            {
                Console.WriteLine("Cancel request!");
                cancelToken.ThrowIfCancellationRequested();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task: {0} is beginning ",id);
            Thread.Sleep(sleepTime);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("task {0} has completed ", id);
        }

        static void DoMoreStuff(int id, int sleepTime, CancellationToken cancelToken)
        {
            if (cancelToken.IsCancellationRequested)
            {
                Console.WriteLine("Cancel request!");
                cancelToken.ThrowIfCancellationRequested();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task: {0} is beginning more stuff ", id);
            Thread.Sleep(sleepTime);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("task {0} has completed more stuff", id);
        }
    }
}
