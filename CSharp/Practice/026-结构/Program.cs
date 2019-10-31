using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_结构
{
    public struct Person
    {
        public string _name;//字段 与变量不同，命名时需+“_”
        public int _age;
        public Gender _gender;
        //结构中也可以放属性、方法
    }
    public struct Animal
    {
        public Person _p;
        //public Gender _gender;
    }
    public enum Gender
    {
        男,
        女
    }



    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////XX大学管理系统
            ////姓名、性别、年龄、系别、年级
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';
            //int zsGrade = 3;

            //结构可以帮助我们一次性声明多个不同类型的变量


            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;
            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;

            MyColor mc;
            mc._red = 255;
            mc._blue = 0;
            mc._green = 0;

            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", zsPerson._name, zsPerson._age, zsPerson._gender);
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生",lsPerson._name,lsPerson._age,lsPerson._gender);

            Animal miao;
            miao._p._age = 19; miao._p._gender = Gender.男; miao._p._name = "miao";
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", miao._p._name, miao._p._age, miao._p._gender);
            Console.ReadKey();
        }
    }
}
