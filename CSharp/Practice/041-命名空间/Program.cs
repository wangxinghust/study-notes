using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _040_面向对象练习2;

namespace _041_命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();//alt+shift+F10或者鼠标选择，将命名空间导入  以及手动写入using
            Ticket t = new Ticket(100);//需要Ticket类加了public关键字，才可以跨命名空间引用
        }
    }
}

//A-->ProjectA-->顾客类
//B-->ProjectB-->顾客类
//C-->ProjectC-->顾客类

//在一个项目中引用另一个项目的类
//1.添加引用
//2.引用命名空间