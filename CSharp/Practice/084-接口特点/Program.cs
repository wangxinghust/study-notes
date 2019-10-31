using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _084_接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new IFlyable();//无法创建抽象类或接口的实例
            IFlyable fly = new Person();
            fly.Fly();
            IFlyable fly2=new Bird();
            fly2.Fly();
            Console.ReadKey();
        }
    }
    public class Person:IFlyable
    {
        public void Fly()//继承了接口，必须实现接口的所有成员
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Student:Person,IFlyable//一个类同时可以继承一个类并实现多个接口，如果一个子类同时继承了父类A，并实现了接口IA，那么语法上A必须写在IA的前面
    {
        public void Fly()
        {
            Console.WriteLine("学生在飞");
        }
    }
    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }
    public interface IFlyable//接口中的成员不能加访问修饰符，接口中的成员访问修饰符默认为public，不能修改
    {
        //接口中只能有方法、属性、索引器、事件，不能有字段和构造函数
        void Fly();//接口中的成员不能有任何实现，子类去实现
    }
    //接口与接口之间可以继承，并且可以多继承
    public interface M1
    {
        void Test1();
    }
    public interface M2
    {
        void Test2();
    }
    public interface M3//:Person  接口不能继承类，只能继承接口
    {
        void Test3();
    }
    public interface SupperInterFace:M1,M2,M3
    {

    }
    public class car : SupperInterFace
    {
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }

}
