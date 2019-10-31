using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 1, 3, 4, 5, 6, 8, 22 });
            list.AddRange(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
            //List泛型集合可以转换为数组 与数组相比，长度可以改变
            int[] nums = list.ToArray();
            List<int> listTwo=nums.ToList();

            List<string> listThree = new List<string>();
            string[] str = listThree.ToArray();

            char[] chs = new char[] { 'c', 'd', 'r' };
            List<char> listChar = new List<char>();
        }
    }
}
