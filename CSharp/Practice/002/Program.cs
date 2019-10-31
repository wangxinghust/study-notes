using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动项目又设置错了。。。。");
            Console.ReadKey();

            #region 变量的定义和使用
            //声明或者定义了一个int类型的变量
            int number;
            number = 0919;//赋值
            Console.WriteLine(number);
            Console.ReadKey();
            double p = 3.12;
            Console.WriteLine(p);
            double x = 4d;
            Console.WriteLine(x);
            string ZsName = "张三";
            Console.WriteLine(ZsName);
            string Z = "";//可以存空
            Console.WriteLine(Z);
            char gender = '男';//不可以存空
            Console.WriteLine(gender);
            decimal money = 500000m;//m后缀必加
            Console.WriteLine(money);
            #endregion

            //+号的使用 字符串的连接 以及数学运算
            string name = "赵四";
            Console.WriteLine("你好啊，" + name);
            Console.WriteLine(5 + "5");
            //占位符{0}的使用 挖坑填坑 少填异常 按挖坑顺序输出
            int number0 = 1;
            int number1 = 2;
            int number2 = 3;
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",number0,number1,number2);
        }

        /// <summary>
        /// 求两整数较大值（文档注释）
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回较大值</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        #region 代码的折叠
        #endregion
        /// <summary>
        /// 解释类的文档注释
        /// </summary>
        public class Person
        {

        }
        
    }
}
