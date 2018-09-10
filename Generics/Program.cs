using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result <int,bool> { Success = true, Data = 6, Data2 = true};
            var result1 = new Result<string, int> { Success = false, Data = "Six", Data2 = 45 };

            Console.WriteLine(result.Success);
            Console.WriteLine(result1.Data2);

            Console.ReadLine();
        }  
        
        public class Result<T,U>
        {
            public bool Success { get; set; }
            public T Data { get; set; }
            public U Data2 { get; set; }
        }
    }
    //not a good practise 
    
    //public class ResultInt
    //{
    //    public bool Success { get; set; }
    //    public int Data { get; set; }
    //}
    //public class ResultString
    //{
    //    public bool Success { get; set; }
    //    public string Data { get; set; }
    //}
    //public class ResultBool
    //{
    //    public bool Success { get; set; }
    //    public bool Data { get; set; }
    //}
}
