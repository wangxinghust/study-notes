using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            string strNumberOne = Console.ReadLine();
            int numOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字");
            string strNumberTwo = Console.ReadLine();
            int numTwo = GetNumber(strNumberTwo);
            //判断第一个数字是否小于第二个数字
            JudgeNumber(ref numOne, ref numTwo);
            //求和
            Console.WriteLine(GetSum(numOne, numTwo));
            Console.ReadKey();
        }
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数字不能大于或等于第二个数字，请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    //调用第一个写的方法
                    n1 = GetNumber(s1);
                    Console.WriteLine("请重新输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
        }

        public static int GetNumber(string s)
        {
            while(true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        public static int GetSum(int n1,int n2)
        {
            int sum = 0;
            for (int i = n1; i < n2; i++)
            {
                sum += i;                
            }
            return sum;
        }
    }
}
