using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 23 };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //for (int i = 0; i < 1000000000; i++)//00:00:02.3482003
            //{
                			 
            //}
            //int[] nums = new int[10000];
            //for (int i = 0; i < nums.Length; i++)//00:00:00.0000471
            //{

            //}
            ////foreach (var item in nums)//00:00:00.0000516  据说数据很大时差异很大
            ////{
                
            ////}
            //sw.Stop();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.WriteLine("==================")
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
