using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_变量交换
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "汪兴";
            //char gender = '男';
            //int age = 23;
            //string tel = "18202728543";
            //Console.WriteLine("我叫{0}，今年{1}岁了，性别{2}，手机号码是{3}。", name, age, gender, tel);
            //Console.ReadKey();

            int n1 = 10;
            int n2 = 22;
            //Console.WriteLine("交换后n1的值是{0}，n2的值是{1}", n2, n1);
            //Console.ReadKey();

            //采用中间变量的方法
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("交换后n1的值是{0}，n2的值是{1}", n1, n2);
            //Console.ReadKey();

            //采用加减的方法,不使用第三方变量
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine("交换后n1的值是{0}，n2的值是{1}",n1,n2);
            Console.ReadKey();
            
        }
    }
}
