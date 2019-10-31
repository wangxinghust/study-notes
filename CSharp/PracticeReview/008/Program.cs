using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.	用方法来实现：计算1-100之间的所有整数的和。
            //11.	用方法来实现：计算1-100之间的所有奇数的和。
            //12.	用方法来实现：判断一个给定的整数是否为“质数”。
            //13.	用方法来实现：计算1-100之间的所有质数（素数）的和。
            int n1 = GetSum();
            int n2 = GetPrimeSum();
        }
        /// <summary>
        /// 计算1-100之间的所有整数的和。
        /// </summary>
        /// <returns></returns>
        public static int GetSum()
        {
            return (1 + 100) * 100 / 2;
        }
        /// <summary>
        /// 计算1-100之间的所有奇数的和。
        /// </summary>
        /// <returns></returns>
        public static int GetOddSum()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }
        /// <summary>
        /// 判断一个给定的整数是否为“质数”。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// 判断一个给定的整数是否为“质数”。用6的倍数两侧来增加判断效率
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime2(int n)
        {
            //小于2的不是质数
            if (n < 2)
            {
                return false;
            }
            //2和3是质数
            else if (n == 2 || n == 3)
            {
                return true;
            }
            //不在6的倍数两侧的数一定不是质数
            else if (n % 6 != 1 && n % 6 != 5)
            {
                return false;
            }
            //在6的两侧的可能也不是质数
            else
            {
                //判断是否能自身整除时，判断到Sqrt(n)即可
                int tmp = (int)Math.Sqrt(n);
                //i<=tmp 等号很重要，要判断到sqrt(n)所得到的整数
                for (int i = 5; i <= tmp; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }
        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                if(IsPrime2(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
