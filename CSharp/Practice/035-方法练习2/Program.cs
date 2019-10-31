using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_方法练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "马龙", "外壳而乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string longest = GetLongest(names);
            //Console.WriteLine(longest);
            //Console.ReadKey();

            //int[] numbers = { 1, 2, 7 };
            //double avg = GetAvg(numbers);
            ////保留两位小数,会四舍五入
            //string s=avg.ToString("0.00");
            //avg = Convert.ToDouble(s);//将avg真正转为两位小数
            //Console.WriteLine("{0:0.00}", avg);//也会四舍五入
            //Console.WriteLine(avg);
            //Console.WriteLine(s);
            //Console.ReadKey();



            //Console.WriteLine("请输入一个数字，我们将会判断他是不是质数");
            //string strNumber = Console.ReadLine();
            //int number = GetNumber(strNumber);

            //bool b = IsPrime(4);
            //Console.WriteLine(b);

            //Console.WriteLine("请输入考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(score);
            //Console.WriteLine(level);
            //Console.ReadKey();

            //string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Test(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();



            //double r = 5;
            //double perimeter;
            //double area;
            //GetPerimeterArea(r, out perimeter, out area);
            //Console.WriteLine("面积是{0}，周长是{1}", area, perimeter);
            //Console.ReadKey();

            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Change(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();


            string[] names = { "梅西", "卡卡", "郑大世" };
            string str = ProcessString(names);
            Console.WriteLine(str);
            Console.ReadKey();

        }

        public static string ProcessString(string[] names)
        {
            string str = null;
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            return str + names[names.Length-1];
        }


        /// <summary>
        /// 冒泡排序，升序排列
        /// </summary>
        /// <param name="nums"></param>
        private static void Change(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 计算圆的周长和面积
        /// </summary>
        /// <param name="r"></param>
        /// <param name="perimeter"></param>
        /// <param name="area"></param>
        public static void GetPerimeterArea(double r, out double perimeter, out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }

        /// <summary>
        /// 数组反转
        /// </summary>
        /// <param name="names"></param>
        private static void Test(string[] names)//数组不需要有返回值，也会改变他的值，不管是改变顺序还是大小
        {
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
        }
        /// <summary>
        /// 求字符串数组中最长的元素
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
        /// <summary>
        /// 求整数数组的平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断是否是质数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number == 2 || number == 3)//
            {
                return true;
            }
            if (number % 6 != 1 && number % 6 != 5)//如果不在6的倍数相邻两侧，则一定不是质数,如果在相邻两侧，条件表达式结果为false，不执行  
            //4不在6的两侧，不是质数，判断正确，而2/3需要单独返回为true，否则在这里会被判断为不是质数，因为2/3也不在6的倍数的相邻两侧
            {
                return false;
            }
            int tmp = Convert.ToInt32(Math.Sqrt(number));
            for (int i = 5; i < tmp; i++)//从5开始整除判断，2/3/4已经由6的倍数排除掉了
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优";
                    break;
                case 8: level = "良";
                    break;
                case 7: level = "中";
                    break;
                case 6: level = "差";
                    break;
                default: level = "不及格";
                    break;
            }
            return level;
        }

    }
}
