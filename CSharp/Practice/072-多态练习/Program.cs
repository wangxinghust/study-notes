using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //RealDuck rd = new RealDuck();
            //WoodDuck wd = new WoodDuck();
            //RubberDuck rud = new RubberDuck();
            //RealDuck[] ducks = { rd, wd, rud };
            //for (int i = 0; i < ducks.Length; i++)
            //{
            //    ducks[i].Bark();
            //}
            //Console.ReadKey();


            //Staff[] staffs={new Staff(),new Manager(),new Programmer()};
            //for (int i = 0; i < staffs.Length; i++)
            //{
            //    staffs[i].PunchClock();			 
            //}
            //Console.ReadKey();

            Animal a = new Dog();
            Animal b = new Cat();
            a.Bark();
            b.Bark();
            Console.ReadKey();

        }
    }
}
