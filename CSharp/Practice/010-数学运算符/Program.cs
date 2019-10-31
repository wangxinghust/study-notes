using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            // %取余


            int n1 = 10;
            int n2 = 3;
            double result = n1 * 1.0 / n2;//×1.0是用来将int提升为double类型的
            Console.WriteLine("{0:0.00}", result);//0.00输出形式为小数点后两位
            //Console.ReadKey();

            int chinese = 90;
            int math = 99;
            int english = 80;
            Console.WriteLine("\n总成绩是{0}，平均成绩是{1}", chinese + math + english, (chinese + math + english) / 3);

            int r = 5;
            double area = 3.14 * r * r;
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("\n圆的面积是{0}，周长是{1}", area, perimeter);

            int t_shirt = 35;
            int trousers = 120;
            int totalMoney = 3 * t_shirt + 2 * trousers;
            Console.WriteLine("\n打折前的价格是{0}", totalMoney);

            // 发生隐式类型转换 目标类型大于源类型
            double realMoney = totalMoney * 0.88;
            Console.WriteLine("打折后的价格是{0}", realMoney);


            //显式类型转换
            int tranToalMoney = (int)realMoney;
            Console.WriteLine("转换后的价格是{0}", tranToalMoney);

            Console.WriteLine("\n46天是{0}周零{1}天", 46 / 7, 46 % 7);
            int seconds = 107653;
            //int second;
            //int min;
            //int hour;
            //int day;
            //second = seconds % 60;
            //min = seconds / 60 % 60;
            //hour = seconds / 60 / 60 % 24;
            //day = seconds / 60 / 60 / 24;
            //Console.WriteLine("\n107653秒时{0}天{1}小时{2}分{3}秒", day, hour, min, second);

            //写法二
            int days = seconds / (60 * 60 * 24);//求天数
            seconds = seconds % (60 * 60 * 24);//求的天数后剩余的秒数
            int hours = seconds / (60 * 60);//求小时数
            seconds=seconds%(60*60);//求完小时数后剩余的秒数
            int mins = seconds / 60;//求的分钟数
            seconds = seconds % 60;//求完分钟数后剩余的秒数
            Console.WriteLine("\n103765秒是{0}天{1}小时{2}分{3}秒", days, hours, mins, seconds);


            Console.ReadKey();
        }
    }
}
