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
            var result = new Result <int> { Success = true, Data = 6};
            var result1 = new Result<string> { Success = false, Data = "Six"};

            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);

            Console.ReadLine();
        }  
        
        public class Result<T>
        {
            public bool Success { get; set; }
            public T Data { get; set; }
            
        }

        public class ResultPrinter
        {
            public void Print<T>(Result<T> result)
            {
                Console.WriteLine(result.Success);
                Console.WriteLine(result.Data);
            }
        }
    }
    //not a good practise 
    //better to use generics
    
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
