using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型 int double char decimal bool enum struct
            //引用类型 string 数组 自定义类 集合 object 接口

            //Person p1 = new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "王五";

            //Console.WriteLine(p1.Name);//p1.Name的值是"王五",引用类型传递的是地址，值同步变化
            //Test(p2);
            //Console.WriteLine(p2.Name);
            //Console.ReadKey();


            //string s1 = "张三";
            //string s2 = s1;
            //s2 = "李四";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.ReadKey();//string不可变性，重新开辟空间存储


            int number = 10;
            TestTwo(ref number);//不加ref的话number的值不会改变
            Console.WriteLine(number);
        }
        public static void TestTwo(ref int n)
        {
            n += 10;
        }
        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "李四";
        }

    }
}
