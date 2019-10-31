using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_多播委托
{
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            //可以指向多个函数
            DelTest del = T1;
            del();
            Console.WriteLine();
            del += T2;
            del();
            Console.WriteLine();
            del += T3;
            del();
            Console.WriteLine();
            del += T4;
            del();
            Console.WriteLine();
            del -= T3;
            del();
            Console.WriteLine();
            del = T4;
            del();
            Console.ReadKey();
        }
        public static void T1()
        {
            Console.WriteLine("我是T1");
        }
        public static void T2()
        {
            Console.WriteLine("我是T2");
        }
        public static void T3()
        {
            Console.WriteLine("我是T3");
        }
        public static void T4()
        {
            Console.WriteLine("我是T4");
        }
    }
    
}
