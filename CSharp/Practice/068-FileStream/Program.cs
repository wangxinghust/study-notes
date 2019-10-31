using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建FileStream对象
            //FileStream fsRead = new FileStream(@"C:\Users\wx\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////返回本次实际读取到的有效字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.Default.GetString(buffer,0,r);//实际上还是读了5M，但只解码了r个字节
            ////关闭流
            //fsRead.Close();
            ////释放流所占用的资源
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();

            using (FileStream fsWrite = new FileStream(@"C:\Users\wx\Desktop\抽象类特点.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str="看我有没有把你覆盖掉";
                byte[] buffer=Encoding.Default.GetBytes(str);//写在文件的开头
                fsWrite.Write(buffer, 0, buffer.Length);
            }//要释放的资源写在using中
            

        }
    }
}
//FileStream   操作字节的
//StreamReader和StreaWriter   操作字符的，只能操作文本文件
//操作小文件用File即可


///将创建文件流对象的过程写在using中，会自动的帮助我们释放流所占的资源