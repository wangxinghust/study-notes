using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象 自定义类 类的实例化
            Person sunQuan=new Person();
            sunQuan.Name = "孙权";//对象的初始化
            sunQuan.Age = 23;
            sunQuan.Gender = '春';
            sunQuan.Chlss();
            Console.ReadKey();
        }
    }
}
