using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_var类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            //C#是一门强类型语言 在代码当中，必须对每一个变量的类型有一个明确的定义
            int n = 15;
            string n2 = "张三";
            double n3 = 3.14;
            decimal n4 = 5000m;
            bool n5 = true;
            char n6 = '男';
            var n7 = 20;//根据值能够推断出来类型
            Console.WriteLine(n.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());
            Console.WriteLine(n5.GetType());
            Console.WriteLine(n6.GetType());
            Console.WriteLine(n7.GetType());
            Console.ReadKey();


            //var input;//隐式类型的变量必须初始化
            //input = "张三";
            
            
            
            //js是一门弱类型语言
            //12 3.14 true "adadwd" 'c' 均用var
        }
    }
}
