using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_面向对象复习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //this
            //new
        }
    }
    internal class Person
    {
        public void T()
        { }
    }
    internal class Teacher : Person//如果父类权限比子类低，会出现可访问性不一致的错误
    {
        public new void T() { }//new 隐藏父类的方法成员
    }
}
