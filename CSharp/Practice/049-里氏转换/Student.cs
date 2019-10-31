using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_里氏转换
{
    class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
}
