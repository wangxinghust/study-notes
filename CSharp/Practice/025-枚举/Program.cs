using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_枚举
{
    //枚举声明到命名空间下，表示整个命名空间下的类都可以使用，声明至类下，结果不同
    
    //声明了一个枚举Gender
    public enum Gender//枚举就是一个变量类型
    {
        男,
        女
    }
    public enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }
    //public enum QQState
    //{
    //    Online=2,//默认从0开始，依次递增
    //    Offline,
    //    leave=7,
    //    Busy,
    //    Qme
    //}
    public enum QQState
    {
        Online=1,
        Offline,
        leave,
        Busy,
        Qme
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //int n = 10;
            //Gender gender = Gender.男;
            //Sesons seson = Sesons.春;
            //QQState state = QQState.Busy;//枚举类型默认可以跟int类型互相转换，枚举类型和int类型是兼容的
            //n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.Online); 
            #endregion

            #region 将int类型强转换为枚举类型
            //int n1 = 3;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state); 
            #endregion


            #region 所有的类型都可以转换成string类型
            //所有的类型都可以转换成string类型
            //int n2 = 10;
            //string s = n2.ToString();
            //double n1 = 3.14;
            //string s1 = n1.ToString();
            //Console.WriteLine(s); 
            #endregion

            #region string转换为枚举类型
            //string s = "0";
            ////将s转换成枚举类型
            ////调用parse（）方法,不常用
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state); 
            //可以将一个枚举类型的变量跟int类型和string类型互相转换
            //枚举类型默认是跟int类型相互兼容的，所以可以通过强制类型转换的语法互相转换
            //当转换一个枚举中没有的值得时候，不会抛异常，而是直接将数字显示出来。
            //枚举同样可以跟string类型互相转换，如果将枚举类型转换为string类型，则直接调用ToString（）
            //如果将字符串转换成枚举类型，则需要下面这样一行代码
            //（要转换的枚举类型）Enum.Parse（typeof（要转换的枚举类型），“要转换的字符串”）
            //如果转换的字符串是数字，则就算枚举中没有，也不会抛异常
            //如果转换的字符串是文本，如果枚举中没有，则会抛出异常
            #endregion


            #region 枚举练习
            Console.WriteLine("请选择您的qq在线状态1-OnLine 2-OffLine 3-Leave 4-Busy");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s1);
                    break;
                case "2": QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s2);
                    break;
                case "3": QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4": QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
            } 
            #endregion
            
            Console.ReadKey();
        }
    }
}
