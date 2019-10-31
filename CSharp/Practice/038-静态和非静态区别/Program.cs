using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_静态和非静态区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用实例成员
            Person p = new Person();
            p.M1();
            //调用静态成员
            Person.M2();
            //静态类是不能实例化的
            //Student s= new Student();
            
            
            
            
            Console.ReadKey();
        }
    }
}
