﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_超市收银系统
{
    class Warehouse
    {
        //存储货物
        //List<ProductFather> list2 = new List<ProductFather>();
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].Name+","+"\t"+"有"+item.Count+"个,\t"+"每个"+item[0].Price+"元");
            }
        }
        //list[0]存储Acer电脑
        //list[1]存储三星手机
        //list[2]存储酱油
        //list[3]存储香蕉
        /// <summary>
        /// 在创建仓库对象的时候，向仓库中添加货架
        /// </summary>
        public Warehouse()
        {
            //for (int i = 0; i < 4; i++)
            //{
            //list.Add(new List<ProductFather>());
            //}
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void Purchase(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch(strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏碁笔记本"));
                        break;
                    case "SamSung": list[1].Add(new ProductFather(Guid.NewGuid().ToString(), 2000, "三星手机"));
                        break;
                    case "SoySauce": list[2].Add(new ProductFather(Guid.NewGuid().ToString(), 30, "酱油"));
                        break;
                    case "Banana": list[3].Add(new ProductFather(Guid.NewGuid().ToString(), 50, "香蕉"));
                        break;
                }
            }
        }
        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] PickUp(string strType,int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {

                    case "Acer": pros[i]=list[0][0];//赋值
                        list[0].RemoveAt(0);//从货架删除
                        break;
                    case "SamSung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "SoySauce": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }
}
