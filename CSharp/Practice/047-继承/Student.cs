using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_继承
{
    class Student : Person
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public void Study()
        {
            Console.WriteLine("学生会学习");
        }
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            this.Id = id;
        }
        public Student()
        {
 
        }
    }
}
