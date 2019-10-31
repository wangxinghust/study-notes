using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //结构：可以一次性声明多个不同类型的变量
            //变量：一次性存储多个相同类型的变量

            //int[] nums=new int[10];//初值默认为0
            ////通过循环给数组赋值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;                
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //string[] str = new string[10];//初值默认为null
            //bool[] bools=new bool[10];//初值默认为false


            //数组的声明方式
            //int[] nums = new int[10];
            //int[] numsTwo = {1,2,3,4,5,6 };
            //int[] numThree = new int[3] { 1, 2, 3 };//不推荐,有关联
            //int[] numFour = new int[] { 1, 2, 3, 4, 5 };


            #region 练习1
            ////声明一个int类型的数组
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ////声明两个变量用来存储最大值和最小值,初值设置为数组第一个值（设置其他的也行），不断的用其他元素和这个元素进行比较
            //int max = int.MinValue;//nums[0];//把int的最小值给max,这样比数组中的每一个元素都小，第一次循环时判断成立
            //int min = nums[0];
            ////声明一个变量用来存储总和
            //int sum = 0;
            ////循环比较
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }
            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("数组中最大值为{0}，最小值为{1}，总和是{2}，平均值是{3}", max, min, sum, sum / nums.Length); 
            #endregion

            #region 练习2
            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老马" };
            //string str = null;
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    str += names[i] + "|";
            //}
            //str += names[names.Length - 1];
            //Console.WriteLine(str); 
            #endregion

            #region 练习3
            //int[] nums = { 1, -2, 3, -4, 5, 6, 0 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        nums[i]--;
            //    }
            //    else if (nums[i] > 0)
            //    {
            //        nums[i]++;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //} 
            #endregion

            #region 练习4 数组倒序输出
            //string[] str = { "a", "b", "c", "d", "e", "f", "h" };
            //for (int i = 0; i < str.Length / 2; i++)
            //{
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //} 
            #endregion




            #region 冒泡排序，升序排列
            int[] nums = { 10,7,4,8,3,6 };
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - 1 - i; j++)//num.Length-1，结果也正确，但是效率更低
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //c#中
            Array.Sort(nums);//升序排列
            Array.Reverse(nums);//反转，如果需要降序，可以先升序再反转
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            } 



            #endregion




            Console.ReadKey();
        }
    }
}
