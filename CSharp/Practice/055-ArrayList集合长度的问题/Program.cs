using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_ArrayList集合长度的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            
            for (int i = 0; i < 5; i++)
            {
                list.Add(1);

                Console.WriteLine(list.Count);
                Console.WriteLine(list.Capacity);
            }
            Console.ReadKey();
            //count 表示这个集合中实际包含的元素的个数
            //capcity 表示这个集合中可以包含的元素的个数 每次集合实际包含的元素个数超过集合可以包含的个数时，集合就会像内存中申请多开辟一倍的空间
        }
    }
}
