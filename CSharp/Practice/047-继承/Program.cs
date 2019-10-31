using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三",18,'男',111);
            
        }
    }
}


//我们可能会在一些类中，写一些重复的成员，我们可以将这些重复的成员，单独的封装到一个类中，作为这些类的父类
//Student Teacher Driver 子类 派生类
//Person                 父类 基类
//子类继承了父类，那么子类从父类哪里继承过来了什么？ 子类不能继承父类的私有字段 子类没有继承父类的构造函数，但是子类会默认的调用父类无参数的构造函数
//如果在父类中重写了一个有参数的构造函数之后，那个无参数的就被干掉了，子类调用不到，会报错
//解决方法  1.在父类中重写一个无参构造函数 2.在子类中显示调用父类的构造函数
//继承的特性
//1.继承的单根性 一个子类只能有一个父类
//2.传递性
//查看类图
//
//object类是所有类的基类