using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_字典集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "wangwu");
            dic.Add(3, "suibian");
            dic[1] = "新来的";
            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine("{0}---{1}", item, dic[item]);
            //}
            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("{0}--{1}",kv.Key,kv.Value);
            }

            Console.ReadKey();
        }
    }
}
