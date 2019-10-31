using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_虚方法和抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class Person
    {
        public virtual void SayHello() { }//虚方法可以重写，也可以不重写
        //public abstract void SayHello();//抽象方法必须重写 抽象成员必须包含在抽象类中 抽象函数不能被static修饰

        public abstract double Test(string name);
    }
    public class Student : Person
    {
        //public void SayHello()
        //{

        //}
        public override double Test(string name)
        {
            return 123;
        }
    }
}
