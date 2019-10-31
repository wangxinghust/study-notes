using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_方法params参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] score = { 99, 88, 77 };
            //Test("张三", score);
            Test("张三", 99, 88, 77);
            Console.ReadKey();
        }
        /// <summary>
        /// 采用params参数，可变参数，将实参列表中跟可变参数数组类型一致的元素都当做数组的元素去处理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public static void Test(string name, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }
    }
}
