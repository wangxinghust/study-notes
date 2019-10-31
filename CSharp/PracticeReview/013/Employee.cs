using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Employee:Person
    {
        public decimal Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("我是Employee类");
        }
    }
}
