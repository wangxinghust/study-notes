using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _052_ArraylList集合;

namespace _053_ToString的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //我们讲一个对象输出到控制台 默认情况下 打印的就是这个对象所在类的命名空间
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(nums);
            Person p = new Person();
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
