using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //object o = n;//装箱
            //int nn = (int)o;//拆箱
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            ////ArrayList list = new ArrayList();
            //List<int> listTwo = new List<int>();
            ////for (int i = 0; i < 10000000; i++)//这个循环发生了1000万次装箱操作  00:00:01.2738636
            ////{
            ////    list.Add(i);
            ////}
            //for (int i = 0; i < 10000000; i++)  //00:00:00.1128658 速度快 需尽量避免装箱拆箱
            //{
            //    listTwo.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();

            //这个操作并没有发生任意类型的装箱和拆箱
            //string str = "123";
            //int n = Convert.ToInt32(str);

            int n = 10;
            IComparable i = n;//装箱
        }
    }
}

//装箱 将值类型转换为引用类型
//拆箱 将引用类型转换为值类型
//看两种类型是否发生了装箱或拆箱，要看这两种类型是否存在继承关系。 所以Convert.ToInt32()没有发生拆箱操作