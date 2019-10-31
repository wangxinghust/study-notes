using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            //20.	将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。
            string s = "  hello      world,你  好 世界   !    ";
            s = s.Trim();
            //s = s.Replace(" ", "");
            string[] sNew = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string strNew= string.Join(" ", sNew);
            Console.WriteLine(strNew);
            Console.ReadKey();
        }
    }
}
