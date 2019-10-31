using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] pers = new Person[8];
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李雷");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("井边子");
            Korea k1 = new Korea("金微笑");
            Korea k2 = new Korea("金秀贤");
            American a1 = new American("科比");
            American a2 = new American("奥尼尔");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Japanese)
                //{
                //    ((Japanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else if (pers[i] is American)
                //{
                //    ((American)pers[i]).SayHello();
                //}
                pers[i].SayHello();//调用的还是父类的SayHello()函数，但这个方法被子类重写了，执行子类重写的方法，具体调用哪个，取决于装的是哪个对象，如果装的就是Person的对象，执行的就是Person的方法
            }
            Console.ReadKey();
        }
    }
}

//多态概念 让一个对象能够表现出多种状态（类型）

//实现多态的手段
//1.虚方法
//将父类的方法标记为虚方法 使用关键字virtual 这个函数可以被子类重新写一遍 在子类当中使用关键字override表示重写
//2.抽象类
//当父类中的方法不知道如何去实现的时候，可以考虑将父类写成抽象类，讲方法写成抽象方法