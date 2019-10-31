using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_CSharp中的各种访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


//private 私有的，只能在当前类的内部访问
//public 公开的公共的
//protected 受保护的，只能在当前类的内部以及该类的子类中访问
//internal 能够修饰类的，只有public和internal  只能在当前程序集中访问（目前可以当做在当前项目中访问）
//protected internal  protected权限加internal权限

//可访问性不一致
//子类的访问权限不能高于父类的访问权限