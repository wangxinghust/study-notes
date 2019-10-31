using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _072_多态练习
{
    public abstract class Animal//标记抽象类
    {
        public abstract void Bark();//标记抽象方法  抽象方法没有方法体

        public void Test()
        {
            //空实现
        }
    }
}
