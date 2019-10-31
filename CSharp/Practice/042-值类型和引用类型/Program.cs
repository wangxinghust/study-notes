using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


//值类型和引用类型
//区别
//1.值类型和引用类型在内存上存储的地方不一样
//2.在传递值类型和传递引用类型的时候，传递的方式不一样
//值类型称之为值传递，引用类型称之为引用传递

//值类型：int、double、bool、char、decimal、struct、enum
//引用类型：string、自定义类、数组  集合、接口
//存储：
//值类型的值是存储在内存的栈当中
//引用类型的值是存储在内存的堆当中