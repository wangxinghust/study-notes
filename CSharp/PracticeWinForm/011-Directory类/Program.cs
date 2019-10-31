using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Path FileStream StreamReader StreamWrite
            //Directory 文件夹 目录
            //创建文件夹
            //Directory.CreateDirectory(@"C:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"C:\a",true);
            //Console.ReadKey();

            //剪切文件夹
            //Directory.Move(@"C:\a", @"C:\Users\wx\Desktop\new");

            //获得指定文件夹下所有文件的全路径
            //string[] path = Directory.GetFiles(@"D:\pic\pic3-this\wallpaper","*.png");

            //获得指定文件夹下所有文件夹的全路径
            //string[] path2= Directory.GetDirectories(@"D:\迅雷下载");

            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"C:\a\b"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"C:\a\b\" + i);
            //    }
            //}

            //彻底删除，回收站中是没有的
            //Directory.Delete(@"C:\a",true);
        }
    }
}
