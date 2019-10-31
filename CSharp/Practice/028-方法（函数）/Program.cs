using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_方法_函数_
{
    class Program
    {
        //如果被调用者想要得到被调用者的值
        //1.参数传递
        //2.使用静态字段模拟全局变量，如下
        public static int _number = 10;

        static void Main(string[] args)
        {
            //方法就是将一堆代码进行重用的一种机制
            // [public] static 返回值类型 方法名（[参数列表]）
            //{
            //    方法体；
            //}
            //static 静态的
            //如果不需要写返回值，写void
            //方法名 Pascal命名
            //return 返回要返回的值并且立即结束当前方法
            //int max = Program.GetMax(3, 6);//Main方法中进行调用   与Main方法在同一类下时，可以省略类名
            //Console.WriteLine(max);
            //bool a = IsRun(2008);//实参 不管是实参还是形参，都是在内存中开辟了空间的
            //Console.WriteLine(a);
            //Console.WriteLine("请输入一个数字");
            //string input = Console.ReadLine();
            //int number = GetNumber(input);
            //Console.WriteLine(number);
            //Console.WriteLine("请输入yes或者no");
            //string input2 = Console.ReadLine();
            //input2 = IsYesOrNo(input2);
            //Console.WriteLine(input2);
            int[] numbers = {1,2,3,4,5,6,7,8 };
            //int[] res = GetMaxMinSumAvg(numbers);
            //Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", res[0], res[1], res[2], res[3]);
            int max=0;
            int min=0;
            int sum=0;
            int avg;//可以不用赋值
            Test(numbers, out max, out min, out sum,out avg);
            Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, avg);
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            string msg;
            bool b = IsLogin(name, pwd, out msg);
            Console.WriteLine("登陆结果{0}", b);
            Console.WriteLine(msg);

            Console.ReadKey();
        }
        /// <summary>
        /// 求两个整数间的较大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>返回是否是闰年的bool值</returns>
        public static bool IsRun(int year)//形参
        {
            bool b = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));
            return b;
        }//方法的功能一定要单一 方法中最忌讳的就是出现提示用户输入的字眼，限制了方法只能用于控制台应用

        /// <summary>
        /// 这个方法需要判断用户的输入是否是数字
        /// 如果是数字，则返回
        /// 如果不是数字，则提示用户重新输入
        /// </summary>
        /// <param name="s">输入的字符串</param>
        /// <returns>字符串转换后的数字</returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 限定输入的字符串是yes或者no，返回
        /// </summary>
        /// <param name="input">要判断的字符串</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no，请重新输入");
                    input = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 计算一个int类型数组的总和
        /// </summary>
        /// <param name="nums">要求总和的数组</param>
        /// <returns>返回这个数组的总和</returns>
        public static int SumOfArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }


        //求一个数组的最大值，最小值，总和，平均值
        //可以返回一个数组 也可以用out参数返回 以及ref、params参数的学习
        //如果返回一个数组的话，需要参数类型相同，限制比较大
        /// <summary>
        /// 求一个数组的最大值，最小值，总和，平均值，采用数组的方式返回
        /// </summary>
        /// <param name="nums">所求数组</param>
        /// <returns>返回该数组的最大值，最小值，总和，平均值</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假设res[0]最大值 res[1]最小值 res[2]总和 res[3]平均值
            res[0] = nums[0];
            res[1] = nums[0];
            res[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }
        /// <summary>
        /// 求数组的最大值最小值总和平均值，采用out参数的方法返回所求的值
        /// </summary>
        /// <param name="nums">所求数组</param>
        /// <param name="max">该数组最大值</param>
        /// <param name="min">该数组最小值</param>
        /// <param name="sum">该数组总和</param>
        /// <param name="avg">该数组平均值</param>
        public static void Test(int[] nums,out int max,out int min,out int sum,out int avg)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }


        //分别的提示用户输入用户名和密码，判断用户输入的是否正确，返回给用户一个登陆结果，并且还要单独的返回给用户一个登陆信息
        //如果用户名错误，除了返回登陆结果之外，还要返回一个用户名错误 密码错误亦然
        /// <summary>
        /// 判断登陆是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">返回登陆信息</param>
        /// <returns>返回登陆的结果</returns>
        public static bool IsLogin(string name,string pwd,out string msg)
        {
            if (name == "admin" && pwd == "888888")
            {
                msg = "登陆成功";
                return true;
            }
            else if(name=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "用户名和密码均错";
                return false;
            }
        }
    }
}
