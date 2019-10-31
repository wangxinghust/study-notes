using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_练习1
{
    class Program
    {
        public enum Level
        {
            优,
            良,
            中,
            差,
            不及格,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的考试成绩");

            //to do 如何解决让他重复输入，直至解决正确输入问题
            //已解决，但是逻辑很复杂，待优化 
            //优化方案：将b值和break换为return即可，return结束main程序
            int score = 0;
            //设置一个bool值标记循环，如果输入的结果满足要求，则跳出循环
            bool b = true;
            while(b)
            {
                try
                {
                    score = Convert.ToInt32(Console.ReadLine());
                    while(true)
                    {
                        if(score<=100&&score>=0)
                        {
                            Console.WriteLine("你的考评给{0}", GetLevel(score).ToString());
                            //b = false;
                            //break;
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("请输入正确范围内的考试成绩");
                            break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("请输入正确格式的考试成绩");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 求该分数的等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static Level GetLevel(int score)
        {
            Level level = Level.优;
            switch (score / 10)
            {
                case 10:
                case 9: level = Level.优;
                    break;
                case 8: level = Level.良;
                    break;
                case 7: level = Level.中;
                    break;
                case 6: level = Level.差;
                    break;
                default: level = Level.不及格;
                    break;
            }
            return level;
        }
    }
}
