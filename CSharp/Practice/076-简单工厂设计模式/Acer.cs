using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_简单工厂设计模式
{
    class Acer:Laptop
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }
}
