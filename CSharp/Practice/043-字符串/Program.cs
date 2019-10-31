using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "张三";
            name = "孙权";
            Console.WriteLine(name);

            string s = "abcdefg";
            Console.WriteLine(s[0]);//通过下标访问
            //s[0] = 'b';
            //首先将字符串转换为char类型的数组
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为我们的字符串
            s = new string(chs);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

//字符串
//1.字符串的不可变性 当你给一个字符串重新赋值之后，老值并没有销毁，而是重新开辟一块空间存储新的值 当程序结束后，GC扫描整个内存，如果发现有的空间没有被指向，则立刻把它销毁
//2.可以将字符串看做是char类型的一个只读数组 只能读取，不能改变