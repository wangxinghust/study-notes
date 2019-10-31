using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.	用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？扩展（*）：计算任意多个数间的最大值（提示：params）。
            int max=GetMax(1,2,3,4,5,67,7,8,9,12,65);
        }
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
