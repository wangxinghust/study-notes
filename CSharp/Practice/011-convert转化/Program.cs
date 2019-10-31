using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_convert转化
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            //将字符串转换成int或double类型，类型之间不兼容，可使用convert转换
            double dou = Convert.ToDouble(str);//使用convert进行类型转换时，需要能转换得过去
            Console.WriteLine(dou);

            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string strEnglish = Console.ReadLine();
            //由于字符串相加的话，最终会变成相连接，如果要那字符串类型的变量参与计算，需要先将字符串转换成int或者double类型
            
            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);
            //Console.WriteLine("\n{0}你的总成绩是{1}，你的平均成绩是{2}", name, chinese + math + english, (chinese + math + english) / 3);

            double chinese = Convert.ToDouble(strChinese);
            double math = Convert.ToDouble(strMath);
            double english = Convert.ToDouble(strEnglish);
            Console.WriteLine("\n{0}你的总成绩是{1}，平均成绩是{2:0.00}", name, chinese + math + english, (chinese + math + english) * 1.0 / 3);

            //提示用户输入一个数字，接收，并且想控制台打印用户输入的这个数字的2倍
            Console.WriteLine("请输入一个数字");
            
            //string strNumber = Console.ReadLine();
            //double number = Convert.ToDouble(strNumber);
            //Console.WriteLine(number * 2);

            //简写
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number * 2);

            Console.ReadKey();

            
            
        }
    }
}
