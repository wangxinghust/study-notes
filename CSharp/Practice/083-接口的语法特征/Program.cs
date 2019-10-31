using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _083_接口的语法特征
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IFlyable
    {
        void Fly();

        string Test();
        //接口中的成员不允许添加访问修饰符，默认就是public
        //接口中的成员不能有定义
        //接口中不允许包含字段
        //接口只包含方法、属性、事件或索引器的签名

        /// <summary>
        /// 自动属性  要限定取值的话，只能通过构造函数了，但是写起来比普通属性方便
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}

//接口是一种规范，只要一个类继承了一个接口，这个类就必须要实现这个接口中的所有成员