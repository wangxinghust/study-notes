using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建了一个计时器，用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i = 0; i < 100000; i++)
            {
                //str += i;//00:00:16.5673367耗时
                sb.Append(i); //00:00:00.0113279耗时
            }
            sw.Stop();//结束计时
            Console.WriteLine(sb.ToString());//一切类型都可以调用ToString()转换为字符串类型
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
