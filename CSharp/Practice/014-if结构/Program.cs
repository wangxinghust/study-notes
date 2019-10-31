using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input your time");
            int mins = Convert.ToInt32(Console.ReadLine());
            if (mins < 60 == false)//如果==true的话，可以省略，==false不能省略
            {
                Console.WriteLine("don't");
            }
            Console.WriteLine("please input your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 32)
            {
                Console.WriteLine("marry your love");
            }
            Console.WriteLine("please input your chinese");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your music");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese > 90 && music > 80) || (chinese == 100 && music < 70))
                Console.WriteLine("congratulation！");//一行时可以不输大括号，但是不好看

            //if-else
            Console.WriteLine("please input the score of Zhao");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("100");
            }
            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine("please input the score of student");
            int scroe2 = Convert.ToInt32(Console.ReadLine());
            #region if嵌套 过于复杂
            if (scroe2 >= 90)
            {
                Console.WriteLine("A");
            }
            else//<90
            {
                if (scroe2 >= 80)
                {
                    Console.WriteLine("B");
                }
                else//<80
                {
                    if (scroe2 >= 70)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        if (scroe2 >= 60)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            Console.WriteLine("E");
                        }
                    }
                }
            }
            #endregion

            //if eles-if结构 用来多区间的判断，选择结构
            if (scroe2 >= 90)
            {
                Console.WriteLine("A");
            }
            else if (scroe2 >= 80)
            {
                Console.WriteLine("B");
            }
            else if (scroe2 >= 70)
            {
                Console.WriteLine("C");
            }
            else if (scroe2 >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }

            //分别提示用户输入三个数字，接收并转换为int类型值           
            Console.WriteLine("请输入第一个数字");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            #region 思路一
            //第一个数字大于第二个且大于第三个
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
            }
            //如果第二个数字大于第一个且大于第三个
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            //如果第三个数字大于第一个且大于第二个
            else
            {
                Console.WriteLine(numberThree);
            }
            #endregion

            #region 思路二
            if (numberOne > numberTwo)
            {
                //如果第一个数字大于第二个，再让第一个数字与第三个比较
                if (numberOne > numberThree)
                {
                    Console.WriteLine(numberOne);
                }
                else//第三个数字大于第一个
                {
                    Console.WriteLine(numberThree);
                }
            }
            else//第二个数字大于第一个
            {
                //让第二个数字与第三个比较
                if (numberTwo > numberThree)
                {
                    Console.WriteLine(numberTwo);
                }
                else //第三个数字大
                {
                    Console.WriteLine(numberThree);
                }
            }
            #endregion


            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            if (pwd == "888888")
            {
                Console.WriteLine("登录成功");
            }
            else//要求用户再输入一次
            {
                Console.WriteLine("密码错误，请重新输入");
                pwd = Console.ReadLine();
                if (pwd == "888888")
                {
                    Console.WriteLine("输了两遍终于对了");
                }
                else
                {
                    Console.WriteLine("两遍都没输对，我可去你的吧");
                }
            }

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwds = Console.ReadLine();
            //第一种情况：用户名和密码全部输入正确
            if (name == "admin" && pwds == "888888")
            {
                Console.WriteLine("登录成功");
            }
            //第二种情况：密码错误
            else if (name == "admin")
            {
                Console.WriteLine("密码输入错误，程序退出");
            }
            else if (pwd == "888888")//第三种情况：用户名错误
            {
                Console.WriteLine("用户名错误，程序退出");
            }
            else //第四种情况：用户名和密码全部错误
            {
                Console.WriteLine("用户民和密码全部错误，程序退出");
            }


            Console.WriteLine("请输入你的年龄");
            int ages = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("想看就看吧");
            }
            else if (age < 10)
            {
                Console.WriteLine("小孩子别看");
            }
            else
            {
                Console.WriteLine("你真的要看吗?yes/no");
                string input = Console.ReadLine();//input要么是yes，要么是no
                if (input == "yes")
                {
                    Console.WriteLine("小心");
                }
                else
                {
                    Console.WriteLine("滚吧");
                }
            }





            Console.ReadKey();
        }
    }
}
