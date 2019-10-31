using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_继承复习
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public void CHLSS()
        {

        }
        public Person(string name, char gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
    }
    public class Student : Person
    {
        public int ID
        {
            get;
            set;
        }
        //在子类中调用父类的构造函数 使用关键字 base
        public Student(string name,char gender,int age,int id):base(name,gender,age)
        {
            this.ID = id;
        }
    }
    public class Teacher : Person
    {
        public double Salary
        {
            get;
            set;
        }
        public Teacher(string name,char gender,int age,double salary):base(name,gender,age)
        {
            this.Salary = salary;
        }
    }

}
