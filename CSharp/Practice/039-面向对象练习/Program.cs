using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三",18,'男',100,100,100);
            //zsStudent.Name = "张三";
            //zsStudent.Age = 18;
            //zsStudent.Gender = '中';
            //zsStudent.Chinese = 100;
            //zsStudent.Math = 100;
            //zsStudent.English = 100;
            zsStudent.SayHello();
            zsStudent.ShowScore();

            Student xlStudent = new Student("晓兰",17,'女',99,99,99);
            //xlStudent.Name = "晓兰";
            //xlStudent.Age = 17;
            //xlStudent.Gender = '女';
            //xlStudent.Chinese = 99;
            //xlStudent.Math = 99;
            //xlStudent.English = 99;
            xlStudent.SayHello();
            xlStudent.ShowScore();

            Console.ReadKey();
        }
    }
}


//关键字new
//Person zsPerson=new Person
//作用：
//1.在内存中开辟了一块空间
//2.在开辟的空间中创建对象
//3.调用对象的构造函数进行初始化对象