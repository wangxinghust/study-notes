using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //仅仅写法有区别，功能基本一样，多用for循环就好


            #region while循环写法
            Console.WriteLine("满意不");
            string answer = Console.ReadLine();
            while (answer == "no")
            {
                Console.WriteLine("又唱了，满意不");
                answer = Console.ReadLine();
            }
            Console.WriteLine("放学");
            #endregion

            #region do-while循环写法
            string ans = "";
            do
            {
                Console.WriteLine("满意不");
                ans = Console.ReadLine();
            }
            while (ans == "no");
            Console.WriteLine("放学");
            #endregion


            #region 练习1
            string name = "";
            string pwd = "";
            do
            {
                Console.WriteLine("请输入用户名");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                pwd = Console.ReadLine();
            }
            while (name != "admin" || pwd != "888888");
            Console.WriteLine("登录成功");
            #endregion

            #region 练习2
            string nam = "";
            do
            {
                Console.WriteLine("请输入学员姓名，输入q结束");
                nam = Console.ReadLine();
            }
            while (name != "q");
            #endregion

            string input = "";
            while (input != "q")
            {
                Console.WriteLine("请输入一个数字，我们将打印这个数字的2倍");
                input = Console.ReadLine();
                if (input != "q")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        Console.WriteLine("您输入的数字的2倍是{0}", number * 2);
                    }
                    catch
                    {
                        Console.WriteLine("输入的不是数字，也不是q，请重新输入");
                    }
                }
                else//==q时
                {
                    Console.WriteLine("输入为q，程序退出");
                }
            }

            string inp="";
            int max = 0;
            while (inp != "end")
            {
                Console.WriteLine("请输入一个数字，输入end时我们将显示最大值");
                inp = Console.ReadLine();
                if (inp != "end")
                {
                    try
                    {
                    int number = Convert.ToInt32(inp);
                    //让输入的每个数字都与max比较，如果比max大，则给max赋值
                    if (number > max)
                    {
                        max = number;
                    }
                    }
                    catch
                    {
                        Console.WriteLine("输入的不是数字和end，请重新输入");
                    }
                }
                else//==end时
                {
                    Console.WriteLine("您输入的最大数为{0}", max);
                }
            }




            Console.ReadKey();
        }
    }
}
