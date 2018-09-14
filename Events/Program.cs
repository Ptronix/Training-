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

            Person Susi = new Person("Susi", tower);

            tower.ChimeFivePM();
            tower.ChimeSixAM();

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
                _tower.Chime += (object sender, ClockTowerEventArgs args) =>
                {
                    Console.WriteLine("{0} heard the clock chime.", _name);
                    switch (args.Time)
                    {
                        case 6:
                            Console.WriteLine("{0} is waking up", _name);
                            break;
                        case 17:
                            Console.WriteLine("{0} is going home.",_name );
                            break;
                    }
                };
            }
        }

        public class ClockTowerEventArgs : EventArgs
        {
            public int Time { get; set;}
        }
         
        public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);

        public class ClockTower
        {
            public event ChimeEventHandler Chime;

            //event with param
            public void ChimeFivePM()
            {
                Chime(this, new ClockTowerEventArgs { Time = 17 });
            }

            public void ChimeSixAM()
            {
                Chime(this, new ClockTowerEventArgs { Time = 6 });
            }
        }
    }
}
