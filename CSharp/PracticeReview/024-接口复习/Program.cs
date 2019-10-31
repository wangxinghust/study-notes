using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_接口复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口是什么？什么时候使用接口？使用接口的目的是什么？ 多态
            IFlyable fly = new Maque();
            fly.Fly();
            Bird fly2 = new Maque();
            fly2.Fly();
            Console.ReadKey();
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }
    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }
    public class QQ : Bird
    {

    }
    public class Maque : Bird,IFlyable
    {
        public new void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        void IFlyable.Fly()//显式实现接口的方法
        {
            Console.WriteLine("实现接口的飞方法");
        }
    }
}
