using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_接口
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class NBAPlayer
    {
        public void Dunk()
        {
            Console.WriteLine("我会扣篮");
        }
    }
    public class Student:Person,IDunkable//需要多继承的时候，可以考虑接口
    {

        public void Dunk()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }
    public interface IDunkable//接口定义 关键字interface
    {
        void Dunk();
    }
}

//接口 就是一个规范 能力