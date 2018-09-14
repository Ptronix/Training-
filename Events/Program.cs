using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {

        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var philipp = new Person("Philipp",tower);

            tower.ChimeFivePM();

            Console.ReadLine();

        }
         
        public class Person
        {
            // this are field´s
            private string _name;
            private ClockTower _tower;
            //konstruktor
            public Person(string name, ClockTower tower)
            {
                _name = name;
                _tower = tower;

                //in parenthis must be the 2 arguments from the delegate
                _tower.Chime += (object sender, EventArgs args) => Console.WriteLine("{0} heard the clock chime.",_name);
            }
        }
         
        public delegate void ChimeEventHandler(object sender, EventArgs args);

        public class ClockTower
        {
            public event ChimeEventHandler Chime;

            public void ChimeFivePM()
            {
                Chime(this, EventArgs.Empty);
            }

            public void ChimeSixAM()
            {
                Chime(this, EventArgs.Empty);
            }
        }
    }
}
