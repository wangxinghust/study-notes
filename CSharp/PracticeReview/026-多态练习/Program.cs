using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class EmPloyee
    {
        public virtual void ClockIn()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    public class Manager : EmPloyee
    {
        public override void ClockIn()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }
    public class Programmer : EmPloyee
    {
        public override void ClockIn()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
