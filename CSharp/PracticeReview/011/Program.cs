using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            //21.	制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，
            //程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名。
            List<string> list = new List<string>();
            while(true)
            {
                Console.WriteLine("请输入学员姓名，输入quit退出");
                string name = Console.ReadLine();
                if(name!="quit")
                {
                    list.Add(name);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("您刚才一共录入了{0}个人的成绩，分别是：", list.Count);
            int i = 0;
            foreach (string item in list)
            {
                if (item[0] == '王')
                {
                    i++;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("姓王的同学一共有{0}个", i);
            Console.ReadKey();
        }
    }
}
