using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //三元表达式   表达式1？表达式2：表达式3；
            //表达式2和表达式3的结果类型一致，与整个三元表达式的类型也一致
            //if-else的简化

            #region 比较数字
            //Console.WriteLine("请输入第1个数字");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第2个数字");
            //int n2 = int.Parse(Console.ReadLine());
            //n1 = n1 > n2 ? n1 : n2;
            //Console.WriteLine("两个数中大的数为{0}", n1); 
            #endregion

            #region 练习2
            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //string result = name == "老赵" ? "人才啊" : "zz";
            //Console.WriteLine(result); 
            #endregion

            //产生随机数
            //1.创建能够产生随机数的对象
            Random r = new Random();
            while (true)
            {
                //2.让产生随机数的对象调用方法来产生随机数
                int rNum = r.Next(1, 7);//F1查看方法使用规则 左闭右开

                //输入名字随机显示这个人上辈子是什么样的人
                Console.WriteLine("请输入一个姓名");
                string name = Console.ReadLine();
                switch (rNum)
                {
                    case 1: Console.WriteLine("zhang");
                        break;
                    case 2: Console.WriteLine("li");
                        break;
                    case 3: Console.WriteLine("wang");
                        break;
                    case 4: Console.WriteLine("zhao");
                        break;
                    case 5: Console.WriteLine("qian");
                        break;
                    case 6: Console.WriteLine("sun");
                        break;
                    case 7: Console.WriteLine("li");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
