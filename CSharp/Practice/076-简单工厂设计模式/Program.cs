using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌 IBM Dell Acer Lenovo");
            string brand = Console.ReadLine();
            Laptop laptop = GetLaptop(brand);
            laptop.SayHello();
            Console.ReadKey();
        }
        /// <summary>
        /// 简单工厂的核心，根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static Laptop GetLaptop(string brand)
        {
            Laptop laptop = null;
            switch (brand)
            {
                case "Lenovo": laptop = new Lenovo();
                    break;
                case "IBM": laptop = new IBM();
                    break;
                case "Acer": laptop = new Acer();
                    break;
                case "Dell": laptop = new Dell();
                    break;
            }

            return laptop;
        }
    }
}

//设计模式
//设计这个项目的一种方式