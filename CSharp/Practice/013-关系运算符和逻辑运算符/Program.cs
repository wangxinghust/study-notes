using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_关系运算符和逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 关系运算符
             * >
             * <
             * >=
             * <=
             * ==
             * !=
             * 返回结果 bool类型 true false
             */
            bool weght = 1500 > 1;


            /*
             * 逻辑运算符
             * &&
             * ||
             * !
             */

            /*
             * 复合赋值运算符 属于二元运算符
             * +=
             * -=
             * *=
             * /=
             */
            int number = 10;
            number += 20;
            bool heal = 2 > 5 || false;

            Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //年份能被400整除
            //年份能被4整除，但是不能被100整除
            bool leapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);//不加括号的话，也是逻辑与先判定，再判定逻辑或，逻辑与的优先级高于逻辑或

            Console.WriteLine("{0},{1},{2}", weght, heal, leapYear);
            Console.ReadKey();
        }
    }
}
