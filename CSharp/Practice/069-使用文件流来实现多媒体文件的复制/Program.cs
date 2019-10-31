using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_使用文件流来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\ProgramStudy\传智播客.Net学院--特供精品.Net基础全套视频教程2014版\特供精品.Net基础全套视频教程2014版--03c#高级\03--面向对象多态\特供.Net基础全套视频教程2014版（第十二天）\video\8、使用FileStream实现多媒体文件的复制.avi";
            string targetPath = @"C:\Users\wx\Desktop\new.avi";
            CopyFile(sourcePath, targetPath);
            Console.WriteLine("复制成功!");
            Console.ReadKey();
        }
        public static void CopyFile(string sourcePath, string targetPath)
        {
            //创建一个负责读取的流
            using(FileStream fsRead=new FileStream(sourcePath,FileMode.Open,FileAccess.Read))
            {
                //创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(targetPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能会比较大，所以需要循环读取
                    while(true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0，说明什么都没有读取到，读取完了跳出循环
                        if(r==0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }

                    
                }
            }
        }
    }
}
