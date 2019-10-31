using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"C:\Users\wx\Desktop\new.txt");//文件重名时仅改变了修改时间，创建时间不变
            //Console.WriteLine("创建成功!");

            //File.Delete(@"C:\Users\wx\Desktop\new.txt");
            //Console.WriteLine("删除成功！");

            //复制文件
            File.Copy(@"C:\Users\wx\Desktop\new.txt", @"C:\Users\wx\Desktop\code.txt");
            Console.ReadKey();
        }
    }
}
