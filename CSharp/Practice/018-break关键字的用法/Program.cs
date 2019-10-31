using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_break关键字的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 跳出switch结构
            //2 跳出while循环

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello World!");
            //    i++;
            //    break;
            //}


            //int i = 1; 
            //int j = 1;
            //while (i <= 10)
            //{
            //    while (j <= 10)
            //    {
            //        Console.WriteLine("内循环");
            //        j++;
            //        break;//结果为交替出现，说明break只是跳出当前循环
            //    }
            //    Console.WriteLine("外循环");
            //    i++;
            //}

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello");
                break;//作用不大，一般跟if判断一起使用，表示当满足某些条件时，不再循环了
            }

            string userName = "";
            string userPwd = "";
            while (userName != "admin" || userPwd != "888888")
            {
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                userPwd = Console.ReadLine();
            }
            Console.WriteLine("登录成功");

            Console.WriteLine("请输入班级人数");
            int count = Convert.ToInt32(Console.ReadLine());
            int i1 = 1;
            int sum = 0;
            while (i1 <= count)
            {
                Console.WriteLine("请输入第{0}个学员的考试成绩", i1 + 1);
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;//表示把每一个学员的成绩累加到总成绩当中
                i1++;//循环次数的++一定不能忘记
            }
            Console.WriteLine("{0}个人的班级的总成绩是{1}，平均成绩是{2}", count, sum, sum / count);

            string answer = "";
            int i2 = 0;
            while (answer != "yes" && i2 < 10)
            {
                Console.WriteLine("这是我第{0}遍讲，你会了吗？yes or no", i2 + 1);
                answer = Console.ReadLine();//yes no
                //如果学生回答的是yes，则应跳出循环
                if (answer == "yes")
                {
                    Console.WriteLine("放学");
                    break;
                }
                else//no 继续循环，可以不写else
                { }
                i2++;
            }


            double people = 80000;
            int year = 2006;
            while (people < 200000)
            {
                people *= 1.25;
                year++;
            }
            Console.WriteLine("到第{0}年的时候人数将达到20万人");

            string ans = "";
            while (ans != "yes" && ans != "no")
            {
                Console.WriteLine("请输入yes或者no");
                ans = Console.ReadLine();
            }

            string userNameA = "";
            while (userNameA == "")
            {
                Console.WriteLine("请输入用户名，并且不能为空");
                userNameA = Console.ReadLine();
            }


            Console.WriteLine("请输入用户名，不能跟A相同，并且不能为空");
            string userNameB = "";
            while (userNameB == "" || userNameB == userNameA)
            {
                if (userNameB == "")
                {
                    Console.WriteLine("用户名不能为空，请重新输入");
                    userNameB = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("用户名不能与A相同，请重新输入");
                    userNameB = Console.ReadLine();
                }
            }



            Console.ReadKey();
        }
    }
}
