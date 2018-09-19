using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace DynamicAndLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            var pythonRuntime = Python.CreateRuntime();

            dynamic pythonFile = pythonRuntime.UseFile("Test.py");

            pythonFile.SayHelloToPython();
        }
    }
}
