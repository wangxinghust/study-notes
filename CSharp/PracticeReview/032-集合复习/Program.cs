using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_集合复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add();
            //Hashtable ht = new Hashtable();
            //可以添加各种元素，但会发生拆装箱等，很麻烦

            //List<int> list = new List<int>();
            //list.Add(); 添加单个元素
            //list.AddRange(); 添加集合
            //list.Insert(); 插入
            //list.InsertRange(); 插入集合
            //list.Remove(); 移除
            //list.RemoveAt(); 根据下标移除
            //list.Contains(); 移除一定范围的元素
            //list.RemoveAll(); 判断是否包含


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "zhangsan");
            dic.Add(2, "lisi");
            dic.Add(3, "yanwei");
            dic[4] = "haishi";
            foreach (KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine("{0}---{1}", kv.Key, kv.Value);
            }
            Console.ReadKey();
            //dic.ContainsKey();


            //集合初始化器
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //对象初始化器 尽量不用
            Person p = new Person() { Name = "张三", Age = 19, Gender = '男' };
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }

}
