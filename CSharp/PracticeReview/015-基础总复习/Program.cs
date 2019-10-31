using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_基础总复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用进程打开指定的文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\wx\Desktop\1.txt");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}
/*
 * 单行注释 //
 * 多行注释
 * 文档注释 ///
 * HTML <!---->
 * CSS 用的多行注释
 */

/*
 * 命名规范
 * Camel骆驼命名规范：要求首单词的首字母小写，其余单词首字母大写，变量、字段等
 * int age string name char gender string hignSchool
 * int _chinese
 * 
 * Pascal:类或者方法 GetMax GetMin GetSum
 */

/*
 * 面向对象
 * 封装、继承、多态
 * 字段：存储数据，访问修饰符应该设置为private私有的
 * 属性：保护字段，对字段的取值和赋值进行限定
 * new关键字：1、在堆中开辟空间 2、在开辟的空间中创建对象 3、调用对象的构造函数
 * this关键字：1、代表当前类的对象 2、调用自己的构造函数
 * 构造函数：初始化对象
 * 对字段的保护方法： 1、get 2、set 3、构造函数
 * return 1、立即结束此方法 2、在方法中返回要返回的值
*/

/*
 * 继承复习
 * 解决代码的冗余，实现多态，增加了代码的扩展性，便于维护
 * 1、单根性 2、传递性
 * 子类并没有继承父类的构造函数，而是会默认调用父类的那个无参数的构造函数
 * 如果一个子类继承了一个父类，那么这个子类除了可以使用自己的成员，而不能使用子类的成员，子类之间也不能互相使用其成员。
*/

/*
 * 里氏转换
 * 1、子类可以赋值给父类
 * 2、如果父类中装的是子类对象，那么可以将这个父类转换为子类对象。
 * 
 * as
 * is
*/

/*
 * 多态
 * 1、虚方法 virtual
 * 2、抽象类 abstract
*/

/*
 * new关键字
 * 1、创建对象
 * 2、在子类中隐藏从父类继承过来的成员
*/

/*
 * 访问修饰符
 * public 公开的、公共的
 * private 私有的，只能在当前类的内部访问，类中的成员，默认就是private
 * protected 受保护的，可以在当前类的内部访问，也可以在该类的子类中访问
 * internal 在当前项目中都可以访问
 * protected internal
 * 
 * 能够修饰类的访问修饰符只有两个 internal和public
*/

/*
 * 常用的关键字
 * this 1、当前类的对象 2、调用自己的构造函数
 * base 调用父类的成员
 * new 1、创建对象 2、隐藏父类的成员
 * virtual 标记一个方法是虚方法
 * abstract 抽象
 * override 重写
 * interface 接口
 * partial 部分类
 * sealed 密封类 不允许被继承
 * return 1、在方法中返回要返回的值 2、立即结束本次方法
 * break 跳出当前循环
 * continue 结束本次循环，回到循环条件进行判断
 * static 静态的
 * struct 结构
 * enum 枚举
 * const 常量 
*/


/*
 * 字符串
 * 不可变性
 * 字符串可以看做是char类型的只读数组
*/

/*
 * ArrayList
 * Hashtable
 * List<T>
 * Dictionary<TKey,TValue>
*/

/*
 * 装箱或者拆箱
 * 装箱：就是将值类型转换为引用类型
 * 拆箱：就是将引用类型转换为值类型
 * 值类型：bool int double char struct enum decimal
 * 引用类型：string 数组 集合 interface object 自定义类
 * 
 * 拆箱或者装箱的两种类型必须具有继承关系
*/

/*
 * 结构和类的区别
 * 结构 值类型
 * 类 引用类型
 * 声明的语法 class struct
 * 在类中，构造函数里 既可以给字段赋值，也可以给属性赋值 构造函数是可以重载的
 * 但是，在结构的构造函数中，必须只能给字段赋值 结构的构造函数，需要给全部的字段赋值，而不能去选择的给字段赋值
 * 
 * 结构也可以new 但结构是在栈中开空间
 * 只是调用结构的构造函数
 * 
 * 
 * 结构和类的相同点
 * 不管是结构还是类，本身都会有一个默认的无参数的构造函数
 * 不同点：在类中写了一个新的构造函数后，那个默认的构造函数被干掉了，但结构的无参构造函数保留
 * 类的构造函数可以重载
 * 
 * 如果只是单纯的存储数据，可以使用结构
 * 面向对象的思维来开发，使用类
*/

/*
 * Path类 对字符串的操作
 * File类 操作文件 复制、剪切、创建、移除 不适合操作大文件
 * Directory类 操作文件夹
 * FileStream类 文件流
 * StreamReader StreamWriter
*/