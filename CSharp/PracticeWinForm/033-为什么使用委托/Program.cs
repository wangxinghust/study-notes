using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_为什么使用委托
{
    //声明委托
    public delegate string delProStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //三个需求
            //1.将一个字符串数组中每个元素都转换成小写
            //2.将一个字符串数组中每个元素都转换成大写
            //3.将一个字符串数组中每个元素两边都加上 引号
            string[] names = { "abCDeFG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            //ProSToLower(names);
            //ProSToUpper(names);
            //ProStrSYH(names);

            //匿名函数
            ProStr(names, delegate(string name)
            {
                return name.ToUpper();
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
        public static void ProStr(string[] name, delProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }
        //public static string StrToUpper(string name)
        //{
        //    return name.ToUpper();
        //}
        //public static string StrToLower(string name)
        //{
        //    return name.ToLower();
        //}
        //public static string StrSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}



        //public static void ProSToUpper(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToUpper();
        //    }
        //}
        //public static void ProSToLower(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToLower();
        //    }
        //}
        //public static void ProStrSYH(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = "\"" + name[i] + "\"";
        //    }
        //}
    }
}

//将一个方法作为参数传给方法