using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //给对象的每个属性赋值的过程称之为对象的初始化
            p.Age = 19;
            p.Gender = '男';
            p.Name = "淼王星";
            p.SayHello();
            Console.ReadKey();
        }
    }
}
