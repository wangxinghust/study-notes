using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_多态练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口练习
        }
    }
    class Bird
    {

    }
    interface _Flyable
    {
        void Fly();
    }
    class Sparrow:Bird,_Flyable
    {
        public void Fly()//public必加 不然会出错，无法实现接口成员
        {
            Console.WriteLine("麻雀会飞");
        }
    }
    class Ostrich : Bird
    {
       
    }
    class Penguin : Bird
    {
       
    }
    class Parrot : Bird, _Flyable
    {
        public void Fly()
        {

        }
    }
}
