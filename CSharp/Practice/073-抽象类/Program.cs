using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用多态求矩形的面积和周长，以及圆形的面积和周长
            Shape circular = new Circular(5);
            double area = circular.GetArea();
            double perimeter = circular.GetPerimeter();
            Console.WriteLine("该圆的面积是{0:0.00}，周长是{1:0.00}", area, perimeter);
            Shape rectangle = new Rectangle(14.3, 23.6);
            area = rectangle.GetArea();
            perimeter = rectangle.GetPerimeter();
            Console.WriteLine("该矩形的面积是{0:0.00}，周长是{1:0.00}", area, perimeter);
            Console.ReadKey();
        }
    }
}


//1.抽象成员必须标记为Abstract，并且不能有任何实现
//2.抽象成员必须在抽象类中
//3.抽象类不能被实例化
//4.子类继承抽象类后，必须把父类中的所有抽象成员都重写
//5.抽象成员的访问修饰符不能是private
//6.在抽象类中可以包含实例成员
//并且抽象类的实例成员可以不被子类实现
//7.抽象类是有构造函数的，虽然不能被实例化
//8.如果父类的抽象方法中有参数，那么继承这个父类的子类在重写父类的方法的时候必须传入对应的参数
//如果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候，也必须要传入返回值
//=========================
//如果父类中的方法有默认的实现，并且父类需要被实例化，这时可以考虑将父类定义成一个普通类，用虚方法来实现多态
//如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类