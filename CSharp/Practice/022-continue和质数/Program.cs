using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_continue和质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("Hello world");
            //    continue;//后面的代码不执行，回到while起点，继续下一次循环



            #region 练习1  加外侧代码Ctrl+K+S
            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey(); 
            #endregion

            //素数（质数）：只能被1和这个数字本身整除的数字,从2开始
            #region 求100内的质数
            int printNum = 0;//定义打印质数时的次数，每五次换行
            for (int i = 2; i <= 100; i++)
            {
                bool b=true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)//如果整除了，说明不是质数，则退出小循环
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.Write(i + "\t");
                    printNum++;
                    if (printNum %4==0)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.ReadKey();
            #endregion



        }
    }
}

