﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_ArraylList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //集合 很多数据的一个集合
            //数组 长度不可变 类型单一
            //集合的好处 长度可以任意改变 类型随意
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add('男');
            list.Add(5000m);
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Person p = new Person();
            list.Add(p);
            list.Add(list);
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if(list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);
                    }
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
                
            }
            Console.ReadKey();
        }
    }
}
