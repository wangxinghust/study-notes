﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_匿名函数
{
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //SayHi("张三", SayHiEnglish);

            //DelSayHi del = delegate(string name)
            //{
            //    Console.WriteLine("你好" + name);
            //};
            //del("张三");

            //lamda表达式 => goes to
            DelSayHi del = (string name) => { Console.WriteLine("你好" + name); };
            del("张三");
            Console.ReadKey();
        }
        //public static void SayHi(string name,DelSayHi del)
        //{
        //    del(name);
        //}
        //public static void SayHiChinese(string name)
        //{
        //    Console.WriteLine("你好"+name);
        //}
        //public static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Hi"+name);
        //}
    }
}
