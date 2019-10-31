using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _087_面向对象总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候用虚方法来实现多态
            //什么时候用抽象类来实现多态
            //什么时候用接口来实现多态

            //真的鸭子会游泳 木头鸭子不会游泳 橡皮鸭子会游泳
            //侧重能力，选择接口
            ISwimming swim = new XpDuck();//new RealDuck();
            swim.Swim();
            Console.ReadKey();
        }
    }
    public class RealDuck : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }
    }
    public class MuDuck
    {

    }
    public class XpDuck : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("橡皮鸭子漂着游泳");
        }
    }
    public interface ISwimming
    {
        void Swim();
    }
}
