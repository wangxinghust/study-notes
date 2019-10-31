using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_File操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\wx\Desktop\抽象类特点.txt");
            ////将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            ////UTF-8  GB2312  GBK ASCII  Unicode
            //string s=Encoding.GetEncoding("GB2312").GetString(buffer);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //string str="今天天气好晴朗处处好风光";
            //byte[] buffer=Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\wx\Desktop\抽象类特点.txt",buffer);
            //Console.ReadKey();

            //string[] contents=File.ReadAllLines(@"C:\Users\wx\Desktop\抽象类特点.txt", Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();


            //string str = File.ReadAllText(@"C:\Users\wx\Desktop\抽象类特点.txt", Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //File.ReadAllText(@"抽象类特点.txt", Encoding.Default);//相对路径

            //File.WriteAllLines(@"C:\Users\wx\Desktop\抽象类特点.txt", new string[] { "aoe", "帝国大厦", "神奇小子" });//写入string[]

            //File.WriteAllText(@"C:\Users\wx\Desktop\抽象类特点.txt", "我们都是好孩子");

            File.AppendAllText(@"C:\Users\wx\Desktop\抽象类特点.txt", "看看覆盖没");
        }
    }
}

//绝对路径和相对路径
//绝对路径 通过给定的这个路径直接能在我的电脑中找到这个文件
//相对路径 文件相对于可执行程序的路径 在开发当中应尽量的去使用相对路径

//File类的缺点，只能读小文件
//大文件需要用到文件流