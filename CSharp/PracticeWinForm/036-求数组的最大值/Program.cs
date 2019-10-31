using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_求数组的最大值
{
    public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            object[] o = { 1, 2, 3, 4, 5 };
            object[] o3 = { "daw", "few12", "fawea42", "asf" };
            object result = GetMax(o, Compare1);
            object result2 = GetMax(o3, Compare2);
            object result3 = GetMax(o3, delegate(object o1, object o2){
                string s1 = (string)o1;
                string s2 = (string)o2;
                return s1.Length - s2.Length;
            });
            object result4 = GetMax(o3, (object o1, object o2) =>
            {
                string s1 = (string)o1;
                string s2 = (string)o2;
                return s1.Length - s2.Length;
            });
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadKey();
        }
        public static object GetMax(object[] nums,DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //要传一个比较的方法
                if (del(max,nums[i])<0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int Compare1(object o1,object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1 - n2;

        }
        public static int Compare2(object o1,object o2)
        {
            string s1 = (string)o1;
            string s2 = (string)o2;
            return s1.Length - s2.Length;
        }
        ///// <summary>
        ///// 求整数数组的最大值
        ///// </summary>
        ///// <param name="nums"></param>
        ///// <returns></returns>
        //public static int GetMax(int[] nums)
        //{
        //    int max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (max < nums[i])
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}
        ///// <summary>
        ///// 求字符串数组的最长值
        ///// </summary>
        ///// <param name="names"></param>
        ///// <returns></returns>
        //public static string GetMax(string[] names)
        //{
        //    string max = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (max.Length < names[i].Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //}
    }
}
