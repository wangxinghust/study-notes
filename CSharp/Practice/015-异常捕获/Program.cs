using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常：语法上无错，运行中，由于某些原因程序出现了错误，不能再正常的运行
            //可以经常性的使用try-catch来进行异常捕获，如果try{}中的代码出现异常，执行catch{}中的代码
            Console.WriteLine("请输入一个数字");//假设输入的不是数字，会发生异常
            //int number;
            bool b = true;
            int number = 0;//声明至外部时还需再次进行赋值操作
            try
            {
                //int number = Convert.ToInt32(Console.ReadLine());
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的内容不能转换为数字");
                b = false;
            }
            //可以将下面这行代码放入try{}中，也可以加一个bool类型值来判断
            if (b)
            {
                Console.WriteLine(number * 2);//变量不在作用域,将number声明到外部
            }


            Console.ReadKey();
        }
    }
}
//变量的作用域：就是能够使用这个变量的范围，一般从声明他的那个括号开始到那个括号所对应的范围结束

//try{}catch{}在所有代码写完后再加，try{}catch{}中间不能有其他代码