using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_____
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            //number++;
            //Console.WriteLine(number);

            //number--;
            //Console.WriteLine(number);

            int result1 = 10 + number++;
            number = 10;
            int result2 = 10 + ++number;
            Console.WriteLine("后++结果{0}，前++结果{1}", result1, result2);
            //结果为20和21，表达式中，后++是用原值参与运算，再+1，前++是先+1，再运算；变量自身都要+1，区别在于表达式的结果

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            //      5     7*2       6     6   表达式中一边进行++一边进行+，按序进行
            Console.WriteLine("{0},{1}", a, b);//结果是7和31
            Console.ReadKey();


            /*
             * ++--只需一个操作数即可完成的运算，称之为一元运算符；
             * + - * / % 对于这些需要两个或以上的才能完成运算的操作符，称之为二元运算符；
             * 如果在一个表达式中，既有一元运算符，又有二元运算符，首先计算一元运算符；
             */

        }
    }
}
