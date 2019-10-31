using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "张三";
            s1 = "李四";//只是改变了指向，值会被GC处理掉
            if(string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("是");
            }


            string s = "abcdefg";
            Console.WriteLine(s[0]);
            char[] chs = s.ToCharArray();
        }
    }
}
