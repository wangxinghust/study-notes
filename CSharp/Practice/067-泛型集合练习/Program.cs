using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_泛型集合练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边 偶数显示在右边。
            #region 练习1
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOdd = new List<int>();
            //List<int> listEven = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        listEven.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listOdd.Add(nums[i]);
            //    }
            //}
            //listOdd.AddRange(listEven);
            //foreach (int item in listOdd)
            //{
            //    Console.Write(item + "  ");
            //}
            //Console.ReadKey(); 
            #endregion


            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            #region 练习2
            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion


            //统计 Welcome to china中每个字符出现的次数，不考虑大小写
            //字符   出现的次数
            //键     值
            #region 练习3
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string str = "Welcome to china";//不考虑大小写，可以将整个字符串转换为小写或大写
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    continue;
                }
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }
            foreach (KeyValuePair<char, int> item in dic)
            {
                Console.WriteLine("{0}--{1}", item.Key, item.Value);
            }
            Console.ReadKey(); 
            #endregion



        }
    }
}
