using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_面向对象
{
    //类是不占内存的，对象占内存
    public class Person//结构是面向过程的，类是面向对象的
    {
        private string _name;//public 公开的 private私有的，仅可在当前类里访问  默认为private
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }//既有get()，又有set()，可读可写只有get()，可读，只有set()，可写
        }
        //属性 作用就是保护字段，对字段的赋值和取值进行限定
        //属性的本质就是两个方法，一个叫get()，一个叫set()
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get//对属性取值时调用
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
            set //对属性赋值时调用
            { _gender = value; }
        }


        /// <summary>
        /// 没有static,动态方法
        /// </summary>
        public void Chlss()
        {
            //this 表示当前这个类的对象 
            Console.WriteLine("我是{0}，我{1}岁，我是{2}生", this.Name, this.Age, this.Gender);//输出属性的值，否则不会调用get方法，要是get方法有限制，则无效了
        }
    }
}
