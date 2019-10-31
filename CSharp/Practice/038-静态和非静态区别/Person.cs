using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_静态和非静态区别
{
    //静态成员必须使用类名去调用，而实例成员使用对象名调用
    public class Person
    {
        private static string _name;
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        private char _gender;
        public void M1()
        {
            //实例方法中，既可以使用静态成员，也可以使用实例成员
            Console.WriteLine("我是费静态的方法");
        }
        public static void M2()
        {
            //静态方法中，只能访问静态成员，不允许访问实例成员。
            Console.WriteLine("我是静态方法");
        }
    }
}


//如果创建的类当做一个“工具类”去使用，可以考虑写成静态类
//静态类在整个项目中资源共享

//堆 栈 静态存储区域
//释放资源。 GC Garbage Collection垃圾回收器