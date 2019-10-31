using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印1000遍，下次考试我一定要细心

            //循环体:Console.WriteLine("下次考试我一定要细心");
            //循环条件：打印的次数小于100遍
            //需要定义一个循环变量来记录循环的次数，每循环一次，循环变量自身都应该加1
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("下次考试我一定要细心\t{0}", i + 1);
                i++;//每循环一次，都要自身加1，否则就要进入死循环
            }

            int i1 = 1;
            int sum = 0;
            while (i1 <= 100)
            {
                if (i1 % 2 == 0)
                {
                    sum += i1;
                }
                i1++;

            }
            Console.WriteLine("\n" + sum);



            Console.ReadKey();
        }
    }
}
