using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061_Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\ProgramStudy\传智播客.Net学院--特供精品.Net基础全套视频教程2014版\特供精品.Net基础全套视频教程2014版--03c#高级\02--面向对象继承\特供.Net基础全套视频教程2014版（第十一天）\video\1、复习~1.avi";
            //int index=str.LastIndexOf("\\");
            //str = str.Substring(index + 1);
            Console.WriteLine(Path.GetDirectoryName(str));//获得文件所在的文件夹的名字
            Console.WriteLine(Path.GetFileName(str));//获得文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));//获得不带扩展名的文件名
            Console.WriteLine(Path.GetExtension(str));//获得扩展名
            Console.WriteLine(Path.GetFullPath(str));//获得全路径名
            Console.WriteLine(Path.Combine(@"c:\a\", "b.text"));
            
            

            Console.ReadKey();
        }
    }
}
