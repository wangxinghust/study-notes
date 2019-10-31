using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder 好处在于进行大量的字符串拼接等操作时，产生的内存垃圾没有string的拼接多
            StringBuilder sb = new StringBuilder();
            sb.Append("zhangsan");
            sb.Append("lisi");
            sb.Append("wangwu");
            sb.Insert(1, 123);
            sb.Replace("w", "wa");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
