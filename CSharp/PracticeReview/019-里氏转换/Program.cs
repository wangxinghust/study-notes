using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();

            Teacher t = person as Teacher;//as 转换不能成返回null

            if(person is Student)//is 返回的值是bool类型
            {
                Console.WriteLine("OK,可以转换");
            }
            else
            {
                Console.WriteLine("NO，不可以转换");
            }

            Student s = (Student)person;
            Console.WriteLine(s.ID);
            Console.ReadKey();
            //Student student = new Student();
            //Teacher teacher = new Teacher();
            
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
    public class Student:Person
    {
        public int ID
        {
            get;
            set;
        }
    }
    public class Teacher : Person
    {
        public double salary
        {
            get;
            set;
        }
    }
}
