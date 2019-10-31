using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            Console.WriteLine("请输入对李四的年终评定");//a b c d e 以及其它
            string level = Console.ReadLine();

            #region if else-if结构解法，但是一般用于多区间判断，而不是多条件的定值的判断
            //bool b=true;
            //if (level == "A")
            //{
            //    salary += 500;
            //}
            //else if (level == "B")
            //{
            //    salary += 200;
            //}
            //else if (level == "C")
            //{

            //}
            //else if (level == "D")
            //{
            //    salary -= 200;
            //}
            //else if (level == "E")
            //{
            //    salary -= 500;
            //}
            //else//输入的不是ABCDE其中之一
            //{
            //    Console.WriteLine("输入有误，程序退出");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine("李四来年的工资是{0}", salary);
            //}
            #endregion
            // ctrl+K+S

            #region switch-case结构
            bool b = true;
            switch (level)
            {
                case "A": salary += 500;
                    break;
                case "B": salary += 200;
                    break;
                case "C": break;
                case "D": salary -= 200;
                    break;
                case "E": salary -= 500;
                    break;
                default: Console.WriteLine("输入有误，程序退出");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("李四来年的工资是{0}", salary);
            }
            #endregion

            //让用户输入姓名，然后显示出这个人上辈子是什么职业
            Console.WriteLine("请输入一个姓名，我们将显示出这个人上辈子的职业");
            string name = Console.ReadLine();
            //老杨 老苏 老马 老蒋 老牛 老虎 老赵
            switch (name)
            {
                case "老杨": Console.WriteLine("上辈子是个抽大烟的");
                    break;
                case "老苏": Console.WriteLine("孙权");
                    break;
                case "老马": Console.WriteLine("鲁肃");
                    break;
                case "老蒋": Console.WriteLine("关羽");
                    break;
                case "老牛": Console.WriteLine("赵云");
                    break;
                case "老虎": Console.WriteLine("帝国");
                    break;
                case "老赵": Console.WriteLine("联邦");
                    break;
                default: Console.WriteLine("刘备");
                    break;
            }

            Console.WriteLine("请输入一个考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());//0-100

            switch (score / 10)
            {
                case 10:      //表示case10和case9要执行的代码是一样的
                // Console.WriteLine("A");
                //    break;
                case 9: Console.WriteLine("A");
                    break;
                case 8: Console.WriteLine("B");
                    break;
                case 7: Console.WriteLine("C");
                    break;
                case 6: Console.WriteLine("D");
                    break;
                default: Console.WriteLine("E");
                    break;

            }


            //输入年份和月份，判断该月天数
            try
            {
                Console.WriteLine("请输入年份");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;//声明一个变量用于存储该月天数
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                //2月的特殊性，需要先判断闰年
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default: day = 30;
                                break;

                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }//if判断月份的括号
                    else
                    {
                        Console.WriteLine("输入的月份不在范围内，程序退出");
                    }
                }//try月份的括号
                catch
                {
                    Console.WriteLine("输入的月份有误，程序退出");
                }
            }//try年份的括号
            catch
            {
                Console.WriteLine("输入的年份有误，程序退出");
            }

            Console.ReadKey();

        }
    }
}
