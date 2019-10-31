using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_方法ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JangJin(ref salary);
            Console.WriteLine(salary);

            int n1 = 10;
            int n2 = 20;
            //n1 = n1 - n2;//中间参数，第一个减第二个
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            Test(ref n1,ref n2);
            Console.WriteLine("交换后的值为{0}和{1}", n1, n2);



            Console.ReadKey();

        }
        /// <summary>
        /// 采用ref参数，能够将一个变量带入一个方法中进行改变，改变完成后，再将改变后的参数值带出方法
        /// </summary>
        /// <param name="salary"></param>
        public static void JangJin(ref double salary)
        {
            salary += 500;
        }
        public static void FaKuan(double salary)
        {
            salary -= 500;
        }
        public static void Test(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
