using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.	用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            Console.WriteLine(GetLongest(names));

            //16.	用方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
            Console.WriteLine(GetAverage(1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10));

            //17.	请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10, 21, 54, 76, 32 };
            BubbleSort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();

            //18.	为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，并给各个数组元素指定一个1-100的随机值，然后计算平均成绩。
            Console.WriteLine(Score());

            ////19.	有如下字符串：【"患者：“大夫，我咳嗽得很重。”     
            //大夫：“你多大年记？”     
            //患者：“七十五岁。”     
            //大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     
            //大夫：“四十岁时咳嗽吗？”     
            //患者：“也不咳嗽。”     
            //大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。
            //需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。
            string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            int index = str.IndexOf("咳嗽");
            Console.WriteLine("第1次出现咳嗽的位置是{0}", index);
            int frequency = 1;
            while (index != -1)
            {                
                frequency++;
                index = str.IndexOf("咳嗽", index + 1);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine("第{0}次找到咳嗽的位置为{1}", frequency, index);
            }


            Console.ReadKey();
        }
        /// <summary>
        /// 输出最长的字符串
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static string GetLongest(params string[] names)
        {
            string longest = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                if (longest.Length < names[i].Length)
                {
                    longest = names[i];
                }
            }
            return longest;
        }
        /// <summary>
        /// 计算出一个整型数组的平均值 计算结果显示小数点后两位（四舍五入）
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double GetAverage(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return Convert.ToDouble((sum * 1.0 / n.Length * 1.0).ToString("0.00"));
        }
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="n"></param>
        public static void BubbleSort(params int[] n)
        {
            for (int i = 0; i < n.Length - 1; i++)
            {
                for (int j = 0; j < n.Length - 1 - i; j++)
                {
                    if (n[j] > n[j + 1])
                    {
                        _005.Program.NumExchange(ref n[j], ref n[j + 1]);
                    }
                }
            }
        }
        public static double Score()
        {
            int[] nums = new int[31];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 101);
            }
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double avg = sum / nums.Length;
            avg = Convert.ToDouble(avg.ToString("0.00"));
            return avg;
        }
    }
}
