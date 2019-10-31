using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //Person p = s;
            Person p = new Student();//   子类赋值给父类

            //string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            //Console.WriteLine(str);
            //Console.ReadKey();

            //Student ss = (Student)p;//如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
            //ss.StudentSayHello();
            //Console.ReadKey();
            
            
            //is的用法
            //if(p is Teacher)
            //{
            //    Teacher ss = (Teacher)p;
            //    ss.TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //as的用法
            Teacher t = p as Teacher;


            Console.ReadKey();
        }
    }
}

//里氏转换
//1.子类可以赋值给父类
//2.如果父类中装的是子类对象，那么可以将这个父类强转为子类对象

//is 表示类型转换 如果转换成功，则返回一个true，否则返回false
//as 表示类型转换 如果转换成功，则返回对应的对象，否则返回一个null