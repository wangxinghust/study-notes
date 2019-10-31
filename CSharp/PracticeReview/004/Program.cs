using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)   name       s.SubString(0,1)      s.SubString(1);
            Console.WriteLine("请输入一个字符串");
            string str = Console.ReadLine();
            str = ProcessStr(str);
            Console.WriteLine(str);
        }
        public static string ProcessStr(string str)
        {
            //截取第一个字母并转成小写
            string s = str.Substring(0, 1).ToLower();
            return s + str.Substring(1);
        }
    }
}
