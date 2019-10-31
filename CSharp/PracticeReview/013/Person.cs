using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public virtual void SayHi()
        {
            Console.WriteLine("我是Person类");
        }
    }
}
