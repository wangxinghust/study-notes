using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter rep = new Reporter("小张", 34, '男', "偷拍");
            rep.ReporterSayHello();
            Programmer prog=new Programmer("小吴",22,'女',3);
            prog.ProgrammerSayHello();
            rep.SayHello();
            prog.SayHello();


            Console.ReadKey();
        }
    }    
}

//new关键字
//1.创建对象
//2.隐藏从父类那里继承过来的同名成员