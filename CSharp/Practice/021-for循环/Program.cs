using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while写法
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("hu");
            //    i++;
            //}
            #endregion

            #region for写法
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("欢迎{0}",i);
            //}


            #endregion

            #region 练习1
            //请打印1-10
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 练习1逆向
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习2
            //求1到100之间的整数和，偶数和，奇数和
            //int sum = 0;
            //int evenSum = 0;
            //int oddSum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenSum += i;
            //    }
            //    else 
            //    {
            //        oddSum += i;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine("整数和是{0}，偶数和是{1}，奇数和是{2}",sum,evenSum,oddSum);

            #endregion

            #region 练习3
            ////找100-999间的水仙花数
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (Math.Pow(i % 10, 3)+Math.Pow(i/10%10,3)+Math.Pow(i/100,3)==i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region 循环嵌套
            //int count = 1;
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <=10; j++)
            //    {
            //        Console.WriteLine("Hello World{0}", count);
            //        count++;
            //    }
            //}

            #endregion


            #region 乘法口诀
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}×{1}={2}\t", j, i, i * j);//这样就是在一行输出
            //    }
            //    Console.WriteLine("\n");//小循环完成后，输入一个回车符
            //}

            #endregion

            #region 练习4
            //Console.WriteLine("请输入一个数字");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= number; i++)
            //{
            //    Console.WriteLine("{0}+{1}={2}", i, number - i, number);
            //}
            #endregion

            #region 转换
            //convert转换失败时抛异常
            //int number = int.Parse("12");//convert调用的实际上还是int.Parse,效率相对低一点
            //Console.WriteLine(number);

            //int number2 = 100;
            //bool b = int.TryParse("123a", out number2);//不抛异常
            //Console.WriteLine(b);
            //Console.WriteLine(number2);//失败时number2还是0，是方法返回的值
            #endregion

            #region 练习5
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩", i + 1);
            //    try
            //    {
            //        int age = int.Parse(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄不在正确范围内，程序退出");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的年龄不在正确范围内，程序退出");
            //        b = false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("输入的平均年龄为{0}", sum / 5);
            //}
            #endregion

            #region 练习6
            //string name = "";
            //string pwd = "";

            //while (true)//死循环，满足条件时用break跳出
            //{
            //    Console.WriteLine("请输入用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd = Console.ReadLine();
            //    if (name == "admin" && pwd == "123456") 
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //}
            #endregion


            #region 练习7
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum += i;
                if (sum > 20)
                {
                    Console.WriteLine("加到{0}的时候和大于20了",i);
                    break;
                }
                
            }
            #endregion

            Console.ReadKey();
        }
    }
}
