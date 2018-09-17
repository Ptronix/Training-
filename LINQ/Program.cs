using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "I enjoy learning C#. Become a good programmer is hard work and you have to read a lot of.";

            var result = from c in sample.ToLower()
                         where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                         group c by c;


            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Count());
            }
            Console.ReadLine();
        }
    }
}
