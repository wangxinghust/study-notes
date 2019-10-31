using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_面向对象复习
{
    class Person
    {
        //字段、属性、构造函数、方法、接口
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                if(value!="孙权")
                {
                    value = "孙权";
                }
                _name = value; }
        }
        private int _age;

        public int Age
        {
            get { 
                if(_age<0||_age>100)
                {
                    return _age = 0;
                }
                return _age; }
            set { _age = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Chinese
        {
            get;
            set;
        }
        public int Math
        {
            get;
            set;
        }
        public int English
        {
            get;
            set;
        }
        public Person()
        {

        }
        public Person(char gender)
        {
            if(gender!='男'&&gender!='女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
        public Person(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Person(string name,int age,char gender):this(name,age,gender,0,0,0)//调用自己的构造函数 this
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
        }
        public void SayHello()
        {
            Console.WriteLine("{0}---{1}---{2}", this.Name, this.Age, this.Gender);//this要加 不然括号内出现同名变量时，输出的值是变量的值
        }
    }
}
