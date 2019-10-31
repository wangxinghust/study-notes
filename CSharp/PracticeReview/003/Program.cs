using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按照一行n个数输出数组  int[]  array = new int[50];     Random r = new Random();  r.Next();
            int[] array = new int[50];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
            }
            Console.WriteLine("一行需放几个数");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
                if((i+1)%n==0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
