using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_静态和非静态区别
{
    public static class Student//静态类中只存在静态成员
    {
        private static string _name;
        public static string Name
        {
            get { return Student._name; }
            set { _name = value; }
        }
        public static void M1()
        {

        }
    }
}
