using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_方法的重载
{
    class Program
    {
        //方法的重载就是方法名相同，参数不同 方法的重载和返回值没有关系
        //1.参数的个数相同，类型不同
        //2.参数的类型相同，个数不同
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            Console.WriteLine(1.4);
            Console.WriteLine(5000m);//F12转到定义
            Console.ReadKey();
        }
        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1,string s2)
        {
            return s1 + s2;
        }
    }
}
