using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_protect访问修饰符
{
    class Student:Person
    {
        public void Test()
        {
            Console.WriteLine(_name);
        }
    }
}

//protected 可以在该类的内部及子类中访问