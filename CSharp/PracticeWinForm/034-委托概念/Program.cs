using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_委托概念
{
    
    class Program
    {
        //声明一个委托指向一个函数 委托所指向的函数必须和其具有相同的签名
        public delegate void DelSayHi(string name);
        static void Main(string[] args)
        {
            //DelSayHi del = SayHiFrench;//new DelSayHi(SayHiChinese);
            //del("张三");
            //Console.ReadKey();

            //Test("张三", SayHiEnglish);
            //Test("李四", SayHiFrench);
            //Console.ReadKey();

            //SayHiFrench("张三");
            //SayHiEnglish("王五");
            //Console.ReadKey();
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了么," + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you," + name);
        }
        public static void SayHiFrench(string name)
        {
            Console.WriteLine("Bonjour," + name);
        }
        public static void Test(string name, DelSayHi del)
        {
            //调用
            del(name);
        }
    }
}
