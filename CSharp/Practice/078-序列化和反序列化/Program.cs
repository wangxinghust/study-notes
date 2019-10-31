using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _078_序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            ////假设要将p传输给另一台电脑
            //using (FileStream fsWrite = new FileStream(@"C:\Users\wx\Desktop\抽象类特点.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //接受对方发送过来的二进制，反序列化成对象
            Person p = new Person();
            using(FileStream fsRead=new FileStream(@"C:\Users\wx\Desktop\抽象类特点.txt",FileMode.Open,FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();

        }
    }
}
//序列化 就是将对象转换为二进制
//反序列化 就是讲二进制转换为对象
//用于传输数据