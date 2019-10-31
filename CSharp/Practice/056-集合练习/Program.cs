using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_集合练习
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 练习1
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum += (int)list[i];
            //}
            //int average = sum / list.Count;
            //int max = (int)list[0];
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ((int)list[i] > max)
            //    {
            //        max = (int)list[i];
            //    }
            //}
            //Console.WriteLine("总和是{0}，平均值是{1},最大数是{2}", sum, average, max);
            #endregion


            #region 练习2
            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rNumber = r.Next(0, 10);
                if (!list.Contains(rNumber))
                {
                    list.Add(rNumber);
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            } 
            #endregion
            Console.ReadKey();
        }
    }
}
