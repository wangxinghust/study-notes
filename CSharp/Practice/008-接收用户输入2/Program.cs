using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_接收用户输入2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input your name");
            //接收用户在控制台的输入
            string name = Console.ReadLine();//string类型来接受
            Console.WriteLine("your name is {0}", name);
            Console.ReadKey();
        }
    }
}
