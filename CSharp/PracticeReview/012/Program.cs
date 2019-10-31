using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            //23.	请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。
            string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            for (int i = 0; i < names.Length/2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - i-1];
                names[names.Length - i-1] = temp;
            }
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
