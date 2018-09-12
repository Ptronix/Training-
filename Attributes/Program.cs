using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get all Attributes
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<BeispielAttribut>().Count() > 0
                        select t;

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
            }
            AnotherClass anotherClass = new AnotherClass();
            

        }
        //AttributeTargets sets the restriction of the Attributes... in this case it can only assigned to a class
        [AttributeUsage(AttributeTargets.Class)]
        //  Metadaten
        //Erstellte Attribut klasse wird von der basis attribut klasse abgeleitet 
        // man kann attribute für Klasssen Methoden... definieren 
        public class BeispielAttribut : Attribute
        {
            public int Age { get; set; }
            public bool IsAdult { get; set; }
        }

        //assign the metadata value and age to Test class
        [BeispielAttribut(Age = 18, IsAdult = true)]

        public class Test
        {   //in this case wont work, because restriction is set to class. --> nedd todo | AttributeTargets.Property
           //[BeispielAttribut]
            public int Amount { get; set; }

            //[BeispielAttribut]
            public string Name { get; set; }

            //[BeispielAttribut]
            public void Method() { }
        }

        [BeispielAttribut(Age = 12 , IsAdult = false)]
        public class AnotherClass
        {

        }

        public class NoAttributesAssigned
        {

        }
        
    }

    
}
