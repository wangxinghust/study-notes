using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_面向对象练习
{
    class Student
    {
        //字段 属性 方法 构造函数


        //析构函数 当程序结束的时候 析构函数才执行
        //帮助我们释放资源
        //GC Garbage Collection
        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }
        public Student(string name,int age,char gender,int chinese,int math,int english)//构造函数和类名一样 连void也不需要
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
            //Console.WriteLine("构造函数");
        }
        //public Student(string name, int age, char gender)://构造函数是可以重载的
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Gender = gender;
        //}
        public Student(string name,int chinese,int math,int english):this(name,0,'c',chinese,math,english)
        {

        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if(value<0||value>100)
                { value = 0; }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if(_gender!='男'&&_gender!='女')
                {
                    return _gender='男';
                }
                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;

        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;

        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我{1}岁了，我{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，总成绩是{1}，平均成绩是{2}",this.Name,this.Chinese+this.Math+this.English,(this.Chinese+this.Math+this.English)/3);
        }
    }
}


//构造函数
//作用 初始化对象（给对象的每个属性依次赋值）
//构造函数是一个特殊的方法
//1.构造函数没有返回值，连void也不能写
//2.构造函数的名称必须跟类名一样

//类当中会有一个默认的无参数的构造函数，当写了一个新的构造函数后，原先的默认的无参数构造函数被取代了

//this关键字
//1.代表当前类的对象
//2.在类当中显示调用本类的构造函数 :this