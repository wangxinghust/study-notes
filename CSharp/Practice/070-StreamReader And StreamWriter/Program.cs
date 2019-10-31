using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070_StreamReader_And_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文件
            //using(StreamReader sr=new StreamReader(@"C:\Users\wx\Desktop\抽象类特点.txt",Encoding.Default))
            //{
            //    while(!sr.EndOfStream)//如果没读取到结尾
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }

            //}
            //Console.ReadKey();

            //使用StreamWriter来写入一个文本文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\wx\Desktop\抽象类特点.txt",true))//
            {
                sw.Write("今天天气好晴朗，写入真简单");//默认会覆盖掉原文件 加上参数设置不覆盖即可
            }
        }
    }
}
