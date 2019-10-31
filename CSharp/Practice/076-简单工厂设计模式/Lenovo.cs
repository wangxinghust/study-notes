using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_简单工厂设计模式
{
    class Lenovo:Laptop
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
}
