using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_HashTable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            //ht.Add(1,"哈哈哈")//会抛异常 键必须是唯一的，值可以重复
            ht[6] = "新来的";//也是一种添加数据的方式
            ht[1] = "把张三干掉";//赋值操作，会覆盖  存在这个键值，替换，没有则添加

            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abd", "cba");
            }
            else
            {
                Console.WriteLine("已经包含abc键值了");
            }
            //ht.Clear();//移除所有元素

            ht.Remove(3);//移除指定键值的元素


            //for (int i = 1; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}
            //Console.WriteLine(ht[false]);//在键值对集合中，是根据键去找值的

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键值是{0}，对应的值是{1}", item, ht[item]);
            }
            Console.ReadKey();
        }
    }
}

//Hashtable 键值对集合 类似字典  孙 sun---孙