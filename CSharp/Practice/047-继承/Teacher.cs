using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_继承
{
    class Teacher:Student
    {
        
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
       
        public void Teach()
        {
            Console.WriteLine("老师会教书");
        }
    }
}
