using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_方法out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        /// <summary>
        /// 自己写的TryParse()方法
        /// </summary>
        /// <param name="s">转换的字符串</param>
        /// <param name="result">返回的int类型</param>
        /// <returns>返回是否转换成功</returns>
        public static bool MyTryParse(string s, out int result)
        {
            result = 0;//转换失败是result为0
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
