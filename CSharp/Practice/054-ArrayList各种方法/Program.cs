using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _054_ArrayList各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list=new ArrayList();
            //添加单个元素
            list.Add(true);
            list.Add(1);
            list.Add("张三");
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            list.AddRange(list);
            //list.Clear();//清空所有元素
            list.Remove(true);//删除单个元素，但只删除匹配的第一个元素
            list.RemoveAt(0);//根据下标删除元素
            list.RemoveRange(0, 3);//根据下标去移除一定范围的元素
            //list.Sort();//升序排列，但是元素无法排序时抛异常
            list.Insert(1, "插入的");//在指定的位置插入元素
            list.InsertRange(3, new string[] { "张三", "李四" });//在指定的位置插入集合
            bool b = list.Contains(1);//确认是否包含某个指定的元素
            list.Add(b);
            if (!list.Contains("闫世伟"))
            {
                list.Add("闫世伟");
            }
            else
            {
                Console.WriteLine("已经有了");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
